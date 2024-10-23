select * 
from product;

-- unit price view
create view unit_price as
select SKU, dept_id, prod_name, size, price, round(price / size, 2) as unit_price, unit
from product;

select *
from unit_price;