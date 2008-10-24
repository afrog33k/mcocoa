# ------------------
# Public variables
CSC ?= gmcs
MONO ?= mono
NUNIT ?= nunit-console2

ifdef RELEASE
	export CSC_FLAGS ?= -checked+ -warn:4 -nowarn:1591 -optimize+
else
	export CSC_FLAGS ?= -checked+ -debug+ -warnaserror+ -warn:4 -nowarn:1591 -define:DEBUG
endif

INSTALL_DIR ?= /usr/local/lib
PKG_CONFIG_DIR ?= /usr/local/lib/pkgconfig

# ------------------
# Internal variables
dummy1 := $(shell mkdir bin 2> /dev/null)			
export dummy2 := $(shell if [[ "$(CSC_FLAGS)" != `cat bin/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > bin/csc_flags; fi)

base_version := 0.1.xxx.0										# major.minor.build.revision
version := $(shell ./get_version.sh $(base_version) build_num)	# this will increment the build number stored in build_num
export version := $(strip $(version))

# ------------------
# Primary targets		
all: animating-views natty

lib: bin/mcocoa.dll

check: bin/tests.dll
	cd bin && "$(NUNIT)" tests.dll -nologo

generate: bin/generate.exe
	cd bin && "$(MONO)" generate.exe --xml=../generate/Frameworks.xml --out=../source
				
animating-views: bin/mcocoa.dll
	cd examples/animating-views && make app
	
run-animating-views: bin/mcocoa.dll
	cd examples/animating-views && make run
	
natty: bin/mcocoa.dll
	cd examples/natty && make app
	
run-natty: bin/mcocoa.dll
	cd examples/natty && make run
	
update-libraries:
	cp `pkg-config --variable=Libraries mobjc` bin

# ------------------
# Binary targets 
cocoa_files := $(strip $(shell find source -name "*.cs" -print))
bin/cocoa_files: $(cocoa_files)
	@echo "$(cocoa_files)" > bin/cocoa_files
		
bin/generate.exe: generate/*.cs bin/csc_flags 
	$(CSC) -out:bin/generate.exe $(CSC_FLAGS) -target:exe generate/*.cs
		
bin/mcocoa.dll: keys bin/csc_flags bin/mobjc.dll bin/cocoa_files
	@./gen_version.sh $(version) source/AssemblyVersion.cs
	$(CSC) -out:bin/mcocoa.dll $(CSC_FLAGS) -keyfile:keys -target:library -reference:bin/mobjc.dll @bin/cocoa_files

bin/tests.dll: bin/csc_flags tests/*.cs generate/*.cs
	$(CSC) -out:bin/tests.dll $(CSC_FLAGS) -pkg:mono-nunit -target:library tests/*.cs generate/*.cs

# ------------------
# Misc targets
keys: 
	sn -k keys

smokey_flags ?= --not-localized -set:naming:jurassic -set:ignoreList:Dictionary.txt
smokey_flags += -exclude-check:P1005	# StringConcat
smokey_flags += -exclude-check:D1047	# TooManyArgs
smokey_flags += -exclude-check:PO1001	# DllImportPath
smokey_flags += -exclude-check:PO1002	# DllImportExtension
smokey_flags += -exclude-check:D1000	# LargeNamespace (should we add namespaces?)
smokey_flags += -exclude-check:D1020	# NativeMethods
smokey_flags += -exclude-check:MS1029	# ClassPrefix (we use NS all over)
smoke: bin/mcocoa.dll
	@-smoke $(smokey_flags) bin/mcocoa.dll

# Note that we do not want to remove mobjc.
clean:
	-rm bin/csc_flags bin/cocoa_files
	-rm -rf bin/AnimatingViews.app
	-rm -rf bin/Natty.app
	-rm bin/animating-views.exe bin/animating-views.exe.mdb 
	-rm bin/natty.exe bin/natty.exe.mdb 
	-rm bin/mcocoa.dll bin/mcocoa.dll.mdb

help:
	@echo "mcocoa version $(version)"
	@echo " "
	@echo "The primary targets are:"
	@echo "lib                  - build the library"
	@echo "animating-views      - build the animating-views sample app"
	@echo "run-animating-views  - build the animating-views sample app"
	@echo "natty                - build the natty sample app"
	@echo "run-natty            - build the natty sample app"
	@echo "update-libraries     - copy the current mobjc libs into bin"
	@echo "install              - install the dll and a pkg-config file"
	@echo "uninstall            - remove the dll and the pkg-config file"
	@echo " "
	@echo "Variables include:"
	@echo "RELEASE - define to enable release builds, defaults to not defined"
	@echo "INSTALL_DIR - where to put the dll, defaults to $(INSTALL_DIR)"
	@echo " "
	@echo "Here's an example:"	
	@echo "sudo make RELEASE=1 install"	

pc_file := $(PKG_CONFIG_DIR)/mcocoa.pc
install: bin/mcocoa.dll
	cp "bin/mcocoa.dll" "$(INSTALL_DIR)"
ifndef RELEASE
	cp "bin/mcocoa.dll.mdb" "$(INSTALL_DIR)"
endif
	@echo "generating $(pc_file)"
	@echo "# Use 'cp \x60pkg-config --variable=Libraries mcocoa\x60 bin' to copy the libraries into your build directory." > $(pc_file)
	@echo "# 'pkg-config --libs mcocoa' can be used to get the gmcs flags." >> $(pc_file)
	@echo "prefix=$(INSTALL_DIR)" >> $(pc_file)
	@echo "Libraries=\x24{prefix}/mcocoa.dll\c" >> $(pc_file)
ifndef RELEASE
	@echo " \x24{prefix}/mcocoa.dll.mdb\c" >> $(pc_file)
endif
	@echo "" >> $(pc_file)
	@echo "" >> $(pc_file)
	@echo "Name: mcocoa" >> $(pc_file)
	@echo "Description: Winforms/Cocoa .NET application framework" >> $(pc_file)
	@echo "Version: $(version)" >> $(pc_file)
	@echo "Libs: -r:mcocoa.dll" >> $(pc_file)

uninstall:
	-rm $(INSTALL_DIR)/mcocoa.dll
	-rm $(INSTALL_DIR)/mcocoa.dll.mdb
	-rm $(pc_file)

tar:
	tar --create --compress --file=mcocoa-$(version).tar.gz AUTHORS Dictionary.txt MIT.X11 Makefile README examples gen_version.sh get_version.sh source

