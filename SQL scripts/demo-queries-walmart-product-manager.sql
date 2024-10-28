-- display raw tables
select * from department;
select * from product;
select * from store;
select * from brand;
select * from employee;
select * from manufactures;
select * from stocks;
select * from store_departments;
select * from works_in;

-- creates view for products with unit price
create view unit_price as
select SKU, dept_id, prod_name, size, price, round(price / size, 2) as unit_price, unit
from product;

-- creates a view with products listed uniquely to stores
create view prod_list_by_store as
select prod_name, SKU, unit_price.dept_ID, price, unit_price, unit, store.store_id
from unit_price
natural join  stocks natural join store
order by prod_name;

-- display views
select * from unit_price;
select * from prod_list_by_store;

-- get all products stocked at every store
with store_cnt(total) as (select count(*) from store) 
select distinct prod_name, SKU, dept_id, price, unit_price, unit
from prod_list_by_store
where SKU = any(
	select SKU
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
where prod_name like "%can%";
 
 -- update price
 
 
 -- find employees who make over X and are hourly working at Y store
 
 
 -- find everyone who works directly under X 
 
 
 -- find everyone who works under X(including who work under those who work directly under them) 
