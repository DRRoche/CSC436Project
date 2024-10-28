select * 
from product;

-- unit price view
create view unit_price as
select SKU, dept_id, prod_name, size, price, round(price / size, 2) as unit_price, unit
from product;

select *
from unit_price;

select * from employee;

select e_id, e_name
from employee
where e_id not in(
	select m_id
	from employee
	where m_id is not null);