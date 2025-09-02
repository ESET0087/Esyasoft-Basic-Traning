create database mydb;

use mydb;

create table employees(id int, emp_name varchar(50), salary int, phone_no int, DOB date);

select * from employees;

insert into employees (id, emp_name, salary, phone_no, DOB) 
values (1, 'Dharmesh', 10000, 1234567890, '2004-02-09'), 
	(2, 'Suraj', 20000, 1876543210, '2000-06-03'), 
	(3, 'Sarvesh', 10000, 1312567890, '2010-02-09'), 
	(4, 'Aman', 6000, 1236543210, '2000-06-03'), 
	(5, 'Anju', 10000, 1230987645, '2004-08-20');

DELETE TOP(1) FROM employees;

select salary from employees;

select * from employees where emp_name = 'Dharmesh';

update employees set salary = 60000 where id = 3;

select * from employees where salary > 10000;
