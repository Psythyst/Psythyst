#!/bin/bash

TOOLS_DIR="Tools"
BIN_DIR="Bin"
PROTOBUILD_EXE=Protobuild.exe

if [ -d $TOOLS_DIR ]; then
    rm -rf $TOOLS_DIR
fi

if [ -d $BIN_DIR ]; then
    rm -rf $BIN_DIR
fi

rm $PROTOBUILD_EXE