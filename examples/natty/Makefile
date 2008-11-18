# ------------------
# Public variables
CSC ?= gmcs
PACK ?= cocoa-pack

ifdef RELEASE
	CSC_FLAGS ?= -checked+ -warn:4 -optimize+
	MONO_FLAGS ?= --desktop			# for some reason we need to pass a flag to mono or cocoa tries to open a document called "natty.exe"
else
	CSC_FLAGS ?= -checked+ -debug+ -warnaserror+ -warn:4 -define:DEBUG
	MONO_FLAGS ?= --debug
endif

# Note that it's important that we do this or the run-natty target will pick up
# our environment variables which will override those used in whatever make file
# we're building. Most apps will not have to worry about this unless they make
# use of these environment variables.
unexport CSC
unexport PYTHON
unexport PACK
unexport RELEASE
unexport CSC_FLAGS
unexport MONO_FLAGS

# ------------------
# Internal variables
bin-path := ../../bin
exe-name := natty
app-name := Natty

app-path := $(bin-path)/$(app-name).app
contents-path := $(app-path)/Contents
macos-path := $(contents-path)/MacOS
exe-path := $(bin-path)/$(exe-name).exe

dummy ?= $(shell if [[ "$(CSC_FLAGS)" != `cat $(bin-path)/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > $(bin-path)/csc_flags; fi)
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
localized-resources := MainMenu.nib,Document.nib,Environment.nib,Flags.nib,Preferences.nib
localized-files := $(shell echo $(localized-resources) | sed "s/,/ /g")

other-resources := AppIcon.icns,Build.png,Cancel.png,$(bin-path)/mobjc-glue.dylib
other-files := $(shell echo $(other-resources) | sed "s/,/ /g")

$(app-path): $(exe-path) Info.plist $(other-files) $(localized-files)
	@echo "building $(app-path)"
	@$(PACK) --app=$(app-path) --exe=$(exe-path) --mono-flags=$(MONO_FLAGS) --plist=Info.plist           \
	--resources=$(gmcs-resources),$(other-resources) --resources=English.lproj:$(localized-resources) \
	--vars=APPNAME:$(app-name),VERSION:$(version),BUILDNUM:$(build-num)
