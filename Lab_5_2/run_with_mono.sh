#!/bin/bash

PROJECT_DIR="/home/webstin/Desktop/university-studing/summer-practice/lab5cp2025-Alexandr-Zaburyannyi/Lab_5_2"

mcs -r:System.Windows.Forms.dll -r:System.Drawing.dll "$PROJECT_DIR/MainForm.cs" "$PROJECT_DIR/MainForm.Designer.cs" "$PROJECT_DIR/Program.cs" -out:"$PROJECT_DIR/KochFractal.exe"

if [ $? -eq 0 ]; then
    echo "Compilation successful! Running the application..."
    mono "$PROJECT_DIR/KochFractal.exe"
else
    echo "Compilation failed!"
fi
