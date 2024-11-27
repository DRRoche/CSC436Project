-- drop database Walmart_Product_Manager;
create database Walmart_Product_Manager;

use Walmart_Product_Manager;

create table department(
dept_ID int,
dept_name varchar(20) NOT NULL,
primary key (dept_ID));

create table product(
SKU int,
dept_ID int,
prod_name varchar(100) NOT NULL,
size numeric(7,3) NOT NULL,
unit ENUM('oz', 'ml', 'lt', 'lb', 'pcs') NOT NULL,
price numeric(8,2) NOT NULL,
primary key (SKU),
foreign key (dept_ID) references department(dept_ID));

create table store(
store_ID int,
street_num int NOT NULL,
street_name varchar(30) NOT NULL,
city varchar(30) NOT NULL,
state varchar(30) NOT NULL,
zip_code int NOT NULL,
primary key (store_ID));

create table brand(
brand_ID char(5),
brand_name varchar(50) NOT NULL,
chain_exclusive bool,
primary key (brand_ID));

create table store_departments(
store_ID int,
dept_id int, 
primary key (store_ID, dept_ID),
foreign key (store_ID) references store(store_ID),
foreign key (dept_ID) references department(dept_ID));

create table stocks(
store_ID int,
SKU int,
primary key (store_ID, SKU),
foreign key (store_ID) references store(store_ID),
foreign key (SKU) references product(SKU));

create table manufactures(
brand_ID char(5),
SKU int,
primary key (brand_ID, SKU),
foreign key (brand_ID) references brand(brand_ID),
foreign key (SKU) references product(SKU));

create table employee(
E_ID int,
M_ID int,
e_name varchar(20) NOT NULL,
position ENUM('Store Manager', 'Assistant Manager', 'Dept Manager', 'Cashier', 'Stocker') NOT NULL,
payroll_type ENUM('Hourly', 'Salary') NOT NULL,
pay_rate numeric(9,2) NOT NULL,
primary key (E_ID));

create table works_in(
dept_ID int, 
E_ID int,
store_ID int,
primary key (dept_ID, E_ID, store_ID),
foreign key (dept_ID) references department(dept_ID),
foreign key (E_ID) references employee(E_ID),
foreign key (store_ID) references store(store_ID));

-- ---------------------------------------------------Indexes and Views ---------------------------------------------------------------------------
-- creates index on price attribute
CREATE INDEX price_idx ON product(price);

-- creates view for products with unit price
create view unit_price as
select SKU, product.dept_id, dept_name, prod_name, size, price, round(price / size, 2) as unit_price, unit
from product left outer join department on product.dept_ID = department.dept_ID;

-- creates a view with products listed uniquely to stores
create view prod_list_by_store as
select prod_name, SKU, unit_price.dept_name, price, unit_price, unit, store.store_id
from unit_price
natural join  stocks natural join store
order by prod_name;
