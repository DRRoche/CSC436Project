create database Walmart_Product_Manager;

use Walmart_Product_Manager;

create table department(
dept_ID char(5), -- Change to enum
dept_name char(20) NOT NULL,
primary key (dept_ID));

create table product(
SKU int,
dept_ID char(5), -- Change to enum
prod_name char(20) NOT NULL,
size int NOT NULL,
unit ENUM('oz', 'lb', 'pcs') NOT NULL,
price numeric(8,2) NOT NULL,
primary key (SKU),
foreign key (dept_ID) references department(dept_ID));

create table store(
store_ID int,
street_num int NOT NULL,
street_name char(20) NOT NULL,
city char(20) NOT NULL,
state char(20) NOT NULL,
zip_code int NOT NULL,
primary key (store_ID));

create table brand(
brand_ID char(5),
brand_name char(20) NOT NULL,
chain_exclusive bool,
primary key (brand_ID));

create table employee(
E_ID int,
M_ID int,
e_name char(20) NOT NULL,
position char(20) NOT NULL,
payroll_type ENUM('Hourly', 'Salary') NOT NULL,
pay_rate numeric(9,2) NOT NULL,
primary key (E_ID));

create table store_departments(
store_ID int,
dept_id char(5), -- Change to enum
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
dept_ID char(5), -- Change to enum
E_ID int,
primary key (dept_ID, E_ID),
foreign key (dept_ID) references department(dept_ID),
foreign key (E_ID) references employee(E_ID));


