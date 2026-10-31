C# File Management System

Project Description

This is a C# Windows Forms application developed as a university practical assignment.

The application demonstrates basic file handling operations using C#.

Project Objectives

- Create a new text file.
- Rename an existing text file.
- Delete an existing text file.
- Display confirmation messages using MessageBox.

Technologies Used

- C#
- .NET Windows Forms
- Visual Studio
- System.IO Namespace

Windows Forms Design

The application contains the following controls:

Control| Purpose
TextBox| Enter file name
Create File Button| Creates a new file
Rename File Button| Changes the file name
Delete File Button| Deletes an existing file
MessageBox| Displays operation results

File Handling Methods

1. File.WriteAllText()

Creates a file and writes text into it.

2. File.Exists()

Checks whether a file exists.

3. File.Move()

Renames or moves a file.

4. File.Delete()

Deletes an existing file.

5. Path.Combine()

Combines a folder path with a file name.

How to Run the Project

1. Download or clone this repository.
2. Open the project using Visual Studio.
3. Build the project.
4. Run the application.
5. Enter a file name, for example "student.txt".
6. Click Create File.
7. Click Rename File to change its name.
8. Click Delete File to remove it.

Practical Testing

- Create: "student.txt"
- Rename: "Renamed_student.txt"
- Delete: Removes the renamed file.

Conclusion

This project demonstrates the basic concepts of file handling in C#, including creating, renaming, and deleting files using the System.IO namespace.

Developed by: Kunbil Abdirashiid Barkhadle

Course: C# Programming
