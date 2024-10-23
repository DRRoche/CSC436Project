select * 
from product;

-- unit price view
create view unit_price as
select *, round(price / size, 2) as unit_price
from product;

select *
from unit_price;