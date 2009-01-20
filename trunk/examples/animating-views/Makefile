# For new projects you will want to change bin-path, exe-name, and app-name.
# You may want to change gmcs-resources, bundle-resources, and source-files.

# ------------------
# Public variables
CSC ?= gmcs
PACK ?= cocoa-pack

ifdef RELEASE
	CSC_FLAGS ?= -checked+ -warn:4 -optimize+
else
	CSC_FLAGS ?= -checked+ -debug+ -warnaserror+ -warn:4 -define:DEBUG
	MONO_FLAGS ?= --debug
endif

# ------------------
# Internal variables
bin-path := ../../bin
exe-name := animating-views
app-name := AnimatingViews

app-path := $(bin-path)/$(app-name).app
contents-path := $(app-path)/Contents
macos-path := $(contents-path)/MacOS
resources-path := $(contents-path)/Resources
exe-path := $(bin-path)/$(exe-name).exe

dummy2 ?= $(shell if [[ "$(CSC_FLAGS)" != `cat $(bin-path)/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > $(bin-path)/csc_flags; fi)
build-num := $(shell echo "$(version)" | cut -d . -f 3)

# ------------------
# Primary targets
all: app

app: $(app-path)

# Note that running this way (instead of via open or the Finder) allows us to see console
# output in the terminal instead of the system log.
run: $(app-path)
	$(macos-path)/launcher

# ------------------
# Binary targets 		

# assembly 
gmcs-resources := $(bin-path)/mobjc.dll,$(bin-path)/mcocoa.dll
gmcs-files := $(shell echo $(gmcs-resources) | sed "s/,/ /g")

source-files := *.cs

$(exe-path): $(bin-path)/csc_flags $(gmcs-files) $(source-files)
	$(CSC) -out:$(exe-path) $(CSC_FLAGS) -r:$(gmcs-resources) -target:exe $(source-files)

# bundle
localized-resources := MainMenu.nib
localized-files := $(localized-resources)

$(app-path): $(exe-path) Info.plist $(bin-path)/mobjc-glue.dylib $(localized-files)
	@echo "building $(app-path)"
	@$(PACK) --app=$(app-path) --exe=$(exe-path) --mono-flags='$(MONO_FLAGS)' --plist=Info.plist           \
	--resources=$(gmcs-resources),$(bin-path)/mobjc-glue.dylib --resources=English.lproj:$(localized-resources) \
	--vars=APPNAME:$(app-name),VERSION:$(version),BUILDNUM:$(build-num)
