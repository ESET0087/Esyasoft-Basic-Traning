-- 1. find all the books all the users and all the orders
select *
from orders o
inner join books b on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id

-- 2. find count of all order
select count(*) as number_of_orders from orders

-- 3. find particular users who ordered these books
select u.name, b.title
from orders o
inner join books b on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
where b.title = 'Half Girlfriend'

-- 4. find books users has order
select u.name, b.title
from users u
inner join orders o on o.user_id = u.user_id
inner join books b on b.product_id = o.product_id

-- 5. find total price of books user has order
select u.name, sum(b.price) as total_price
from books b
inner join orders o on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
group by u.name

-- 6. find most valuable user
select u.name, sum(b.price) as total_price 
from books b
inner join orders o on b.product_id = o.product_id
inner join users u on o.user_id = u.user_id
group by u.name
having sum(b.price) = (
    select max(total_price)
    from (
        select sum(b2.price) as total_price
        from books b2
        inner join orders o2 on b2.product_id = o2.product_id
        group by o2.user_id
    ) user_totals
)

-- 7. find range of books from high to low
select * from books order by price desc

-- 8. find the highest price book
select top 1 * from books order by price desc

-- 9. find the cheapest book
select top 1 * from books order by price asc

-- 10. find newly added books
select * from books order by product_id desc