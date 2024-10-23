select * 
from product;

create view unit_price as
select *, round(price / size, 2) as unit_price
from product;

select *
from unit_price;