USE master 
GO

DROP DATABASE IF EXISTS Project_Organizer

CREATE DATABASE Project_Organizer
GO

USE Project_Organizer

BEGIN TRANSACTION

CREATE TABLE department
(
	department_id int identity (1, 1),
	department_name varchar (100) NOT NULL,

	constraint pk_department primary key (department_id)
	
);

CREATE TABLE project
(
	project_id int identity (1, 1),
	project_name varchar (100) NOT NULL,
	start_date date NOT NULL,

	constraint pk_project primary key (project_id)
);

CREATE TABLE employee
(
	employee_id int identity (1001, 1),
	job_title varchar (100) NOT NULL,
	first_name varchar (50) NOT NULL,
	last_name varchar (50) NOT NULL,
	gender varchar (50) NOT NULL, 
	birth_date date NOT NULL,
	hire_date date NOT NULL,
	department_id int NOT NULL,
	project_id int
	
	constraint pk_employee primary key (employee_id),
	constraint fk_department foreign key (department_id) REFERENCES department (department_id)
);

CREATE TABLE employee_projects
(
	employee_id int NOT NULL, 
	project_id int NOT NULL,

	CONSTRAINT pk_employee_project_id PRIMARY KEY (employee_id, project_id)
);
	

INSERT INTO department (department_name)
VALUES ('Department Of Microsoft Office Enthusiasts'), 
('Department Of Neurological Advancement Of Inanimate Objects'), ('HR')

INSERT INTO project (project_name, start_date)
VALUES ('PowerPoint 2021', '2020-02-14'), ('A4B6C7', '1964-12-12'), 
('Project Top Secret Project', '2022-02-02'), ('Employee Retention How-To', '2020-02-14')

INSERT INTO employee (job_title, first_name, last_name, gender, birth_date, hire_date, department_id)
VALUES ('PowerPoint fanatic', 'Bob', 'Bob', 'male', '1972-04-17', '2016-05-14', 1),
('Word fanatic', 'Square', 'Doodle', 'male', '1981-08-08', '2014-01-02', 1),
('Excel fantatic', 'Wendy', 'Mindy', 'female', '1991-03-03', '2018-09-13', 1), 
('Clippy(Microsoft Office Assistant) Advocate', 'Gandalf', 'Grey', 'male', '1911-03-28', '2000-01-01', 1),
('Neurophysiologist', 'Petunia', 'Carmichael', 'female', '1984-05-21', '2008-08-19', 2),
('Roboticist/Research Ethics Boardmember', 'Hector', 'Vector', 'male', '1990-11-11', '2004-09-02', 2),
('Accountant', 'Bill', 'Smith', 'male', '1978-03-02', '2019-12-30', 3),
('Office Manager', 'Cindy', 'Mendy', 'female', '1980-08-08', '1999-08-08', 3);

INSERT INTO employee_projects (employee_id, project_id) VALUES (1001, 1)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1002, 1)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1003, 1)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1004, 1)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1005, 2)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1006, 3)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1007, 4)
INSERT INTO employee_projects (employee_id, project_id) VALUES (1008, 4)


COMMIT TRANSACTION

SELECT *
FROM employee
JOIN project ON employee.project_id = project.project_id
JOIN department ON employee.department_id = department.department_id;





