create database Walmart_Product_Manager;

use Walmart_Product_Manager;

create table department(
dept_ID int,
dept_name char(20),
primary key (dept_ID));

create table product(
SKU int,
dept_ID int,
prod_name char(20),
size int,
unit char(5),
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


