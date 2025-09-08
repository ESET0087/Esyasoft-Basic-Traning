create database ecom
-- created database

use ecom
-- to use database

create table users (user_id int primary key, email varchar(20), name varchar(20))
-- created users table having id, email and name

create table books (product_id int primary key, title varchar(20), price int)
-- created books table having id, title and its price

create table orders (order_no int primary key, 
	user_id int foreign key (user_id) references users(user_id), 
	product_id int foreign key (product_id) references books(product_id))
-- created orders table having order id and user_id refering from users and product_id refering books

insert into users 
	values (1, 'callmebhai@gmail.com', 'GopalBhai'), 
	(2, 'toxicmanji@gmail.com', 'Manjit'),
	(3, 'kalajadu@gmail.com', 'SoumyaDeep'),
	(4, 'vimalpan@gmail.com', 'JaiSai'),
	(5, 'ghostlaugh@gmail.com', 'Nami')

insert into books 
	values (101, 'MSSQL', 100), 
	(102, 'Half Girlfriend', 699),
	(103, 'Black Magic', 700),
	(104, 'Marfa', 2000),
	(105, 'How to Laugh', 2001)

insert into orders 
	values (401, 1, 101), 
	(402, 2, 103),
	(403, 2, 102),
	(404, 3, 103),
	(405, 3, 104),
	(406, 4, 102),
	(407, 5, 105),
	(408, 5, 102)

-- inserted values in respective tables

select u.name, b.title 
from orders o
inner join books b on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
-- query to display name and books 

select u.name
from orders o
inner join books b on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
where b.title = 'Black Magic'
-- query for user who bought black magic book

select u.name, b.title, o.order_no
from orders o
inner join books b on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
where b.price = (
	select max(b.price) from books b
)
-- query to find name of user, title of book having maxium price and order number using subquery
