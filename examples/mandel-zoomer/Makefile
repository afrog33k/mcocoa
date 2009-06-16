# For new projects you will want to change exe-name and app-name.

# ------------------------------------------------------------------------
# Public variables
CSC ?= gmcs
PACK ?= cocoa-pack
NUNIT ?= nunit-console2
GCC ?= gcc
GENDARME ?= /usr/local/bin/gendarme

ifdef RELEASE
	CSC_FLAGS += -warn:4 -optimize+ -d:TRACE
	MONO_FLAGS += --desktop
else
	CSC_FLAGS += -checked+ -debug+ -warnaserror+ -warn:4 -d:DEBUG -d:TRACE
	MONO_FLAGS += --desktop --debug
endif

GCC_FLAGS ?= -Wall -Werror -O3

ifdef USE_LIBGMP
	CSC_FLAGS += -d:LIBGMP
	GCC_FLAGS += -lgmp -DLIBGMP
endif

# ------------------------------------------------------------------------
# Internal variables
exe-name := mandel-zoomer
app-name := MandelZoomer

app-path := bin/$(app-name).app
exe-path := bin/$(exe-name).exe

dummy := $(shell mkdir bin 2> /dev/null)
dummy := $(shell if [[ "$(CSC_FLAGS)" != `cat bin/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > bin/csc_flags; fi)

base_version := 0.6.xxx.0										# major.minor.build.revision
version := $(shell mget_version.sh $(base_version) build_num)	# this will increment the build number stored in build_num
version := $(strip $(version))

build-num := $(shell echo "$(version)" | cut -d . -f 3)
dummy := $(shell mgen_version.sh $(version) source/AssemblyVersion.cs /dev/null)
dummy := $(shell if [[ "$(GCC_FLAGS)" != `cat bin/gcc_flags 2> /dev/null` ]]; then echo "$(GCC_FLAGS)" > bin/gcc_flags; fi)

# ------------------------------------------------------------------------
# Primary targets		
all: app

app: $(app-path)

# Note that running this way (instead of via open or the Finder) allows us to see 
# console output in the terminal instead of the system log.
run: $(app-path)
	$(app-path)/Contents/MacOS/launcher

# ------------------------------------------------------------------------
# Binary targets 	

# native lib
bin/native.dylib: bin/gcc_flags *.c
	$(GCC) -o bin/native.dylib $(GCC_FLAGS) -m32 -dynamiclib  *.c

# assembly 
source-files := source/*.cs source/backend/*.cs

$(exe-path): bin/csc_flags bin/mobjc.dll bin/mcocoa.dll $(source-files)
	$(CSC) -out:$@ $(CSC_FLAGS) -unsafe+ -r:bin/mobjc.dll,bin/mcocoa.dll -target:exe $(source-files)

# bundle
nib-files := $(wildcard source/*.nib)
nib-resources := $(shell echo $(nib-files) | sed "s/ /,/g")

$(app-path): $(exe-path) bin/native.dylib source/Info.plist $(nib-files) AppIcon.icns palettes/*.xml
	@echo "building $(app-path)"
	@$(PACK) --app=$(app-path) --exe=$(exe-path) \
	--mono-flags='$(MONO_FLAGS)' \
	--plist=source/Info.plist \
	--resources=bin/mobjc.dll,bin/mcocoa.dll,palettes,bin/native.dylib,AppIcon.icns \
	--resources=English.lproj:$(nib-resources) \
	--vars=APPNAME:MandelZoomer,VERSION:$(version),BUILDNUM:$(build-num)

# ------------------------------------------------------------------------
# Misc targets
update-libraries:
	cp `pkg-config --variable=Libraries mobjc` bin
	cp `pkg-config --variable=Libraries mcocoa` bin

# Note that we only clean what we built: so mcocoa and mobjc are
# not removed.
clean:
	-rm bin/csc_flags
	-rm bin/gcc_flags
	-rm bin/native.dylib
	-rm $(exe-path)
	-rm $(exe-path).mdb
	-rm -rf $(app-path)

gendarme_flags := --severity all --confidence all --ignore gendarme.ignore --quiet
gendarme: $(exe-path)
	@$(GENDARME) $(gendarme_flags) $(exe-path)
	
help:
	@echo "MandelZoomer version $(version)"
	@echo " "
	@echo "The primary targets are:"
	@echo "app              - build the app"
	@echo "run              - run the app"
	@echo "gendarme         - run gendarme on the app"
	@echo "update-libraries - copy the installed libs into bin"
	@echo " "
	@echo "Variables include:"
	@echo "RELEASE    - define to enable release builds"
	@echo "USE_LIBGMP - define to enable infinite precision math"

