CREATE TABLE EMPLOYEES (
emp_id INT PRIMARY KEY,
Name VARCHAR(50),
dept_id INT NULL,
Salary INT,
hire_date DATE);
CREATE TABLE Department(
dept_id INT PRIMARY KEY,
dept_name VARCHAR(50));
INSERT INTO Department(dept_id,dept_name)
VALUES
(10, 'HR'),
(20, 'IT'),
(30, 'Sales'),
(40, 'Finance');
SELECT*FROM Department;
INSERT INTO EMPLOYEES (emp_id,Name,dept_id,Salary,hire_date)VALUES
(1,' Alice', 10, 50000,' 2021-01-15'),
(2,' Bob', 20, 60000,' 2020-04-20'),
(3,' Charlie', 10, 45000,' 2019-07-10'),
(4,' David', 30, 70000,' 2021-01-15'),
(5,' Eva', NULL, 55000,' 2023-06-12');
SELECT*FROM EMPLOYEES;
ALTER TABLE EMPLOYEES
ADD CONSTRAINT
FK_EMPLOYEES_Department
FOREIGN KEY(dept_id) REFERENCES Department(dept_id);
SELECT e.Name AS employee_name,d.dept_name AS deptname
FROM EMPLOYEES e
JOIN Department d ON e.dept_id=d.dept_id;
SELECT Name,Salary
FROM EMPLOYEES
WHERE Salary>(SELECT AVG(Salary)
FROM EMPLOYEES);
SELECT d.dept_name AS deptname,COUNT(e.emp_id)AS emp_nums
FROM Department d
JOIN EMPLOYEES e
ON d.dept_id=e.dept_id
GROUP BY dept_name
HAVING COUNT(e.emp_id)>1;
SELECT d.dept_name,e.Name 
FROM Department d
LEFT JOIN EMPLOYEES e
ON d.dept_id=e.dept_id;
SELECT d.dept_name AS deptname,COUNT(e.emp_id)AS emp_count
FROM Department d
JOIN EMPLOYEES e 
ON d.dept_id=e.dept_id
GROUP BY d.dept_name
ORDER BY COUNT(e.emp_id)DESC;
SELECT TOP 2 e.Name ,e.Salary
FROM EMPLOYEES e
JOIN Department d
ON d.dept_id=e.dept_id
WHERE dept_name='IT'
ORDER BY e.Salary DESC;
SELECT Name,Salary 
FROM EMPLOYEES
WHERE Salary>(SELECT AVG(e2.Salary)
FROM EMPLOYEES e2
JOIN Department d2 ON e2.dept_id=d2.dept_id
WHERE d2.dept_name='Sales');
UPDATE  e 
SET e.Salary =e.Salary*1.10
FROM EMPLOYEES e
JOIN Department d ON e.dept_id=d.dept_id
WHERE dept_name='HR';
SELECT*FROM EMPLOYEES;
SELECT e.Name,e.Salary,d.dept_name
FROM EMPLOYEES e
JOIN Department d 
ON e.dept_id=d.dept_id
WHERE e.Salary=(SELECT MAX(e2.Salary)FROM EMPLOYEES e2
WHERE e2.dept_id=e.dept_id);

