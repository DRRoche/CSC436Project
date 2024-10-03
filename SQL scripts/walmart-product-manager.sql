create database Walmart_Product_Manager;

use Walmart_Product_Manager;

create table department(
dept_ID char(5),
dept_name char(20),
primary key (dept_ID));

create table product(
SKU int,
dept_ID char(5),
prod_name char(20),
size int,
unit ENUM('oz', 'lb', 'pcs') NOT NULL,
price numeric(8,2),
primary key (SKU),
foreign key (dept_ID) references department(dept_ID));

create table store(
store_ID int,
street_num int,
street_name char(20),
city char(20),
state char(20),
zip_code int,
primary key (store_ID));

create table brand(
brand_ID char(5),
brand_name char(20),
chain_exclusive bool,
primary key (brand_ID));

create table employee(
E_ID int,
M_ID int,
e_name char(20),
position char(20),
payroll_type char(7),
pay_rate numeric(9,2),
primary key (E_ID));

create table store_departments(
store_ID int,
dept_id char(5),
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

create table works_in(
dept_ID char(5),
E_ID int,
primary key (dept_ID, E_ID),
foreign key (dept_ID) references department(dept_ID),
foreign key (E_ID) references employee(E_ID));






