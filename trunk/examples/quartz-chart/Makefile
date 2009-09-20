# For new projects you will want to change exe-name and app-name.
# This is based on the Quartz Composer developer example.

# ------------------------------------------------------------------------
# Public variables
CSC ?= gmcs
PACK ?= cocoa-pack
MONO ?= mono
GENERATE ?= ../../../bin/generate.exe
GET_VERSION ?= mget_version.sh
GEN_VERSION ?= mgen_version.sh

ifdef RELEASE
	CSC_FLAGS += -warn:4 -optimize+ -d:TRACE
	MONO_FLAGS += --desktop
else
	CSC_FLAGS += -checked+ -debug+ -warnaserror+ -warn:4 -d:DEBUG -d:TRACE
	MONO_FLAGS += --desktop --debug
endif

# ------------------------------------------------------------------------
# Internal variables
exe-name := quartz-chart
app-name := QuartzChart
framework-name := quartz

app-path := bin/$(app-name).app
exe-path := bin/$(exe-name).exe
framework-path := bin/$(framework-name).dll

dummy := $(shell mkdir bin 2> /dev/null)
dummy := $(shell if [[ "$(CSC_FLAGS)" != `cat bin/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > bin/csc_flags; fi)

base_version := 0.6.xxx.0										# major.minor.build.revision
version := $(shell "$(GET_VERSION)" $(base_version) build_num)	# this will increment the build number stored in build_num
version := $(strip $(version))

build-num := $(shell echo "$(version)" | cut -d . -f 3)
dummy := $(shell "$(GEN_VERSION)" $(version) source/AssemblyVersion.cs /dev/null)

# ------------------------------------------------------------------------
# Primary targets		
all: app

app: $(app-path)

generate: QuartzFramework.xml
	cd bin && "$(MONO)" --debug $(GENERATE) --xml=../QuartzFramework.xml --out=../quartz

# Note that running this way (instead of via open or the Finder) allows us to see 
# console output in the terminal instead of the system log.
run: $(app-path)
	$(app-path)/Contents/MacOS/launcher

# ------------------------------------------------------------------------
# Binary targets 	

# assembly 
dll-files := quartz/*.cs quartz/core/generated/*.cs quartz/composer/generated/*.cs
$(framework-path): bin/csc_flags bin/mobjc.dll bin/mcocoa.dll $(dll-files)
	@"$(GEN_VERSION)" $(version) quartz/AssemblyVersion.cs
	$(CSC) -out:$@ $(CSC_FLAGS) -target:library -reference:bin/mobjc.dll,bin/mcocoa.dll $(dll-files)

exe-files := source/*.cs
$(exe-path): bin/csc_flags bin/mobjc.dll bin/mcocoa.dll $(framework-path) $(exe-files)
	$(CSC) -out:$@ $(CSC_FLAGS) -unsafe+ -r:bin/mobjc.dll,bin/mcocoa.dll,$(framework-path) -target:exe $(exe-files)

# bundle
nib-files := $(wildcard source/*.nib)
nib-resources := $(shell echo $(nib-files) | sed "s/ /,/g")

$(app-path): $(exe-path) source/Info.plist $(nib-files)
	@echo "building $(app-path)"
	@$(PACK) --app=$(app-path) --exe=$(exe-path) \
	--mono-flags='$(MONO_FLAGS)' \
	--plist=source/Info.plist \
	--resources=bin/mobjc.dll,bin/mcocoa.dll,Chart.qtz,$(framework-path) \
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
	@echo "update-libraries - copy the installed libs into bin"
	@echo " "
	@echo "Variables include:"
	@echo "RELEASE    - define to enable release builds"

