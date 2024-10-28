-- List all products
select * from product;
select * from employee;

-- unit price view
create view unit_price as
select SKU, dept_id, prod_name, size, price, round(price / size, 2) as unit_price, unit
from product;

-- creates a view with products listed uniquely to stores
create view prod_list_by_store as
select prod_name, SKU, unit_price.dept_ID, price, unit_price, unit, store.store_id
from unit_price
natural join  stocks natural join store
order by prod_name;

select * from unit_price;
select * from prod_list_by_store;


-- get all products stocked at every store
with store_cnt(total) as (select count(*) from store) 
select *
from prod_list_by_store
where exists(
	select SKU, cnt
    from(
		select SKU, count(store_id) as cnt 
        from prod_list_by_store 
        group by SKU) as a 
	where a.cnt = (select total from store_cnt));
    
-- get all products at a given store
select * 
from prod_list_by_store
where store_id = 4;

-- find products containing <string>
select *
from unit_price
where prod_name like "%oil%";

