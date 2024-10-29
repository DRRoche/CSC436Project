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
where prod_name like "%coffee%";
 
-- update price single item
select * from unit_price where prod_name like "%coffee%";
update product
set price = price + (price * .07)
where sku = 114669629;
select * from unit_price where prod_name like "%coffee%";
 
-- update price for whole dept
select * from unit_price where prod_name like "%coffee%";
update product
set price = price + (price * .07)
where dept_id = 11;
select * from unit_price where prod_name like "%coffee%";

-- alter table constraint
alter table stocks
drop foreign key stocks_ibfk_2;

alter table stocks
add constraint stocks_ibfk_2
foreign key (SKU) references product(SKU) on delete cascade;

alter table manufactures
drop foreign key manufactures_ibfk_2;

alter table manufactures
add constraint manufactures_ibfk_2
foreign key (SKU) references product(SKU) on delete cascade;

-- remove product
delete from product
where SKU = 129570465;
 
-- find employees who make over X and are hourly working at Y store
select *
from employee
left outer join works_in on employee.e_id = works_in.e_id
where payroll_type = "Hourly" 
and pay_rate > 15.00 
and store_id = 3;
 
-- find everyone who works directly under X 
select *
from employee
where m_id = 2;
 
-- find everyone who works under X(2 levels deep)** 
with emp as (select e_id from employee where e_id = 42) 
select *
from employee
where m_id = (select * from emp)
union
select *
from employee
where m_id = any(
	select e_id
	from employee
	where m_id = (select * from emp));
 
-- find everyone who works at X store in Y dept
select *
from employee
left outer join works_in on employee.e_id = works_in.e_id
where store_id = 1 and dept_id = 11;
 
 