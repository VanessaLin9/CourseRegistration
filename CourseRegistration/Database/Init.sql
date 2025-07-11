CREATE DATABASE CourseRegistrationDb;
GO

USE CourseRegistrationDb;
GO

CREATE Table Teachers (
  Id INT PRIMARY KEY IDENTITY,
  Name NVARCHAR(100),
  Email NVARCHAR(100),
  Account NVARCHAR(50),
  Password NVARCHAR(100),
  CreatedAt DATETIME DEFAULT GETDATE()
);


CREATE Table Students (
  Id INT PRIMARY KEY IDENTITY,
  Name NVARCHAR(100),
  Account NVARCHAR(50),
  Password NVARCHAR(100),
  CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE Table Classes (
  Id INT PRIMARY KEY IDENTITY,
  Title NVARCHAR(100),
  Description NVARCHAR(500),
  TeacherId INT,
  CreatedAt DATETIME DEFAULT GETDATE(),
  FOREIGN KEY (TeacherId) REFERENCES Teachers(Id)
);

CREATE Table ClassStudents (
  Id INT PRIMARY KEY IDENTITY,
  ClassId INT,
  StudentId INT,
  CreatedAt DATETIME DEFAULT GETDATE(),
  UpdatedAt DATETIME DEFAULT GETDATE(),
  CONSTRAINT UQ_Class_Student UNIQUE (ClassId, StudentId),
  FOREIGN KEY (ClassId) REFERENCES Classes(Id),
  FOREIGN KEY (StudentId) REFERENCES Students(Id)
);

-- seed data--
INSERT INTO Teachers (Name, Email, Account, Password) VALUES
('Alice', 'alice@example.com', 'alice01', 'hashedpwd');

INSERT INTO Students (Name, Account, Password) VALUES
('Bob', 'bob01', 'hashedpwd');

INSERT INTO Classes (Title, Description, TeacherId) VALUES
('Intro to C#', 'Basic C# programming course', 1);

INSERT INTO ClassStudents (ClassId, StudentId) VALUES (1, 1);