-- task 1 - find the top 2 most expensive books ordered by each user

select * from (
	select u.user_id as id, u.name, b.title, b.price, 
	row_number () over (partition by u.user_id order by b.price desc) as row_price,
	rank () over (partition by u.user_id order by b.price desc) as rank_price,
	dense_rank () over (partition by u.user_id order by b.price desc) as dense_rank_price
	from orders o
	inner join books b on b.product_id = o.product_id
	inner join users u on u.user_id = o.user_id
) as rank_books
where row_price <= 2
order by id, row_price;

-- task 2 - find how much each user spent in total and rank them

select u.user_id, u.name, sum(b.price) as total_spending,
rank () over (order by sum(b.price) desc) as rank_price,
dense_rank () over (order by sum(b.price) desc) as dense_rank_price
from books b
inner join orders o on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
group by u.user_id, u.name