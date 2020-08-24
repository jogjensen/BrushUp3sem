# BrushUp3sem
Brush up for 3. semster
PROG Exercise: Brush up, Student
In this exercise you must brush up some of your knowledge from 1st and 2nd semester.

You must program a class Student, Unit test the class, and finally document the class.

Getting started
Make a new project in Visual Studio. Type: "Class Library (Portable)".

Class Student
Make a class Student with properties like

Name, at least 2 characters
Address, not null
Semester, 1 <= semester <= 8
Gender, Enum with values Male and Female
Your class probably needs a constructor to deal with the invariants (requirements) mentioned.
Avoid duplicate code!

Unit test the class Student
Your unit test must have a good coverage.

Document the class Student
Document your class Student using /// (triple slash comments).

Document all public parts of your class.

Class Teacher
Make another class Teacher with properties like

Name, at least 2 characters
Address, not null
Salary, salary >= 0
Gender, Enum with values Male and Female
Refactor: Superclass
The classes Student and Teacher has a lot in common.

Put the common stuff (properties and methods) in a common superclass Person.

Run the tests after the refactoring.

Extras (if you have extra time...)
Override methods from class Object

ToString()
Equals(...)
GetHashCode()
Extract an interface IStudent from the Student class. Use the interface in your test - and maybe elsewhere.

Extra extra (if you want to try something really interesting ...)
Make another class Student2 using CodeContracts.

Introduction to CodeContracts.

Use the same/similar Unit test as in the first part of this exercise.
