NAMESPACE := $(notdir $(CURDIR))
run:
	mono ./bin/$(NAMESPACE).exe
build:
	rm ./bin -rf
	mkdir ./bin
	mcs EntryPoint.cs src/*.cs -out:./bin/$(NAMESPACE).exe
clean:
	rm ./bin -rf
