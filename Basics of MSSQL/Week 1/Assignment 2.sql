-- creating database

create database meter

use meter

-- creating customer and smart meter reading table

create table customers (
	customerID int primary key, 
	name varchar(30), 
	address varchar(100), 
	region varchar(5))

create table SmartMeterReadings (
	meterID int primary key, 
	customerID int foreign key (customerID) references customers(customerID),
	location varchar(20),
	installedDate Date, 
	readingDateTime datetime, 
	energyConsumed float)

select * from customers

select * from SmartMeterReadings

-- inserting data into respective table

insert into customers 
	values 
		(101, 'dk', '302', 'north'),
		(102, 'sk', '58', 'north'),
		(103, 'suraj', 'ramgaj', 'west'),
		(104, 'sapri', 'sikkim', 'east'),
		(105, 'ashwin', 'banglore', 'south')

-- YYYY-MM-DD
-- YYYY-MM-DD HH:MM:SS

insert into SmartMeterReadings 
	values 
		(301, 101, 'rooftop', '2024-12-01', '2024-12-01 10:00:00', 6),
		(302, 102, 'rooftop', '2025-01-10', '2025-01-10 12:00:00', 10),
		(303, 103, 'basement', '2023-06-15', '2024-06-15 09:00:00', 78),
		(304, 104, 'underground', '2025-02-23', '2025-02-23 10:00:00', 20),
		(305, 105, '3rd floor', '2020-08-07', '2024-08-07 11:00:00', 49)

-- TASK 1

select meterID, readingDateTime, energyConsumed from SmartMeterReadings
where energyConsumed between 10 and 50
and installedDate <= '2024-06-30'
and readingDateTime between '2024-01-01' and '2024-12-31'

-- TASK 2

select customerID, avg(energyConsumed) as AvgEnergyConsumed, max(energyConsumed) as maxEnergyConsumed
from SmartMeterReadings
group by customerID
	