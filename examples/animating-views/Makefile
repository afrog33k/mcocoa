# For new projects you will want to change exe-name and app-name.

# ------------------
# Public variables
CSC ?= gmcs
PACK ?= cocoa-pack

ifdef RELEASE
	CSC_FLAGS ?= -warn:4 -optimize+ -d:TRACE
	MONO_FLAGS += --desktop
else
	CSC_FLAGS ?= -checked+ -debug+ -warnaserror+ -warn:4 -define:DEBUG
	MONO_FLAGS ?= --desktop --debug
endif

# ------------------
# Internal variables
exe-name := animating-views
app-name := AnimatingViews

app-path := bin/$(app-name).app
exe-path := bin/$(exe-name).exe

dummy := $(shell mkdir bin 2> /dev/null)
dummy := $(shell if [[ "$(CSC_FLAGS)" != `cat bin/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > bin/csc_flags; fi)

base_version := 0.6.xxx.0										# major.minor.build.revision
version := $(shell mget_version.sh $(base_version) build_num)	# this will increment the build number stored in build_num
version := $(strip $(version))

build-num := $(shell echo "$(version)" | cut -d . -f 3)
dummy := $(shell mgen_version.sh $(version) AssemblyVersion.cs /dev/null)
dummy := $(shell if [[ "$(GCC_FLAGS)" != `cat bin/gcc_flags 2> /dev/null` ]]; then echo "$(GCC_FLAGS)" > bin/gcc_flags; fi)

# ------------------
# Primary targets
all: app

app: $(app-path)

# Note that running this way (instead of via open or the Finder) allows us to see console
# output in the terminal instead of the system log.
run: $(app-path)
	$(app-path)/Contents/MacOS/launcher

# ------------------
# Binary targets 		

# assembly 
gmcs-resources := bin/mobjc.dll,bin/mcocoa.dll
gmcs-files := $(shell echo $(gmcs-resources) | sed "s/,/ /g")

source-files := *.cs

$(exe-path): bin/csc_flags $(gmcs-files) $(source-files)
	$(CSC) -out:$(exe-path) $(CSC_FLAGS) -r:$(gmcs-resources) -target:exe $(source-files)

# bundle
nib-files := $(wildcard *.nib)
nib-resources := $(shell echo $(nib-files) | sed "s/ /,/g")

$(app-path): $(exe-path) Info.plist bin/mobjc-glue.dylib $(nib-files) AppIcon.icns
	@echo "building $(app-path)"
	@$(PACK) --app=$(app-path) --exe=$(exe-path) \
	--mono-flags='$(MONO_FLAGS)' \
	--plist=Info.plist \
	--resources=$(gmcs-resources),bin/mobjc-glue.dylib,AppIcon.icns \
	--resources=English.lproj:$(nib-resources) \
	--vars=APPNAME:$(app-name),VERSION:$(version),BUILDNUM:$(build-num)

# ------------------------------------------------------------------------
# Misc targets
update-libraries:
	cp `pkg-config --variable=Libraries mobjc` bin
	cp `pkg-config --variable=Libraries mcocoa` bin

# Note that we only clean what we built: so mcocoa and mobjc are
# not removed.
clean:
	-rm bin/csc_flags
	-rm $(exe-path)
	-rm $(exe-path).mdb
	-rm -rf $(app-path)

help:
	@echo "$(app-name) version $(version)"
	@echo " "
	@echo "The primary targets are:"
	@echo "app              - build the app"
	@echo "run              - run the app"
	@echo "update-libraries - copy the installed libraries into bin"
	@echo " "
	@echo "Variables include:"
	@echo "RELEASE - define to enable release builds"

