-- Show a list of all student names (unique only).
select * from Students2024
union 
select * from Students2025

-- Show a list of all student names (including duplicates).
select * from Students2024
union all
select * from Students2025

-- Display employee names in UPPERCASE and LOWERCASE.
select upper(name) as upper_name from employees
select lower(name) as lower_name from employees

-- Find the length of each employee’s name.
select name, len(name) as len_name from employees

-- Show only the first 3 letters of each name.
select substring(name, 1, 3) as len_name from employees

-- Replace Finance department with Accounts.
select *, replace(Department, 'Finance', 'Accounts') as new_dept from employees

-- Create a new column showing "Name - Department" using CONCAT.
select *, concat(name, ' - ', department) as name_and_dept from Employees

-- Show today’s date using GETDATE().
select GETDATE() as today_date

-- Find the duration (in days) of each project using DATEDIFF.
select *, DATEDIFF(day, StartDate, EndDate) as time_taken from Projects

-- Add 10 days to each project’s EndDate using DATEADD.
select *, dateadd(DAY, 10, EndDate) as new_enddate from Projects

-- Find how many days are left until each project ends.
select *, datediff(day, getdate(), EndDate) as time_left from Projects

-- Convert today’s date into DD/MM/YYYY format using CONVERT.
select convert(varchar(10), getdate(), 103) as today_date

-- Convert a float 123.456 into an integer using CAST.
select cast(123.456 as int)

-- For employees (from Employees table above), categorize them:
-- If Dept = IT → show Tech Team
-- If Dept = HR → show Human Resources
-- Else → Other
select *,
    case 
        when Department = 'IT' then 'Tech Team'
        when Department = 'HR' then 'Human Resources'
        else 'Other'
    end as dept_category
from Employees