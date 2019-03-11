# Write your MySQL query statement below
select Name as Customers
from Customers
where not Id in (select distinct CustomerId from Orders)