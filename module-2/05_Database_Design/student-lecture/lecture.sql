USE master 

DROP DATABASE IF EXISTS ArtGallery

CREATE DATABASE ArtGallery
GO

USE ArtGallery

CREATE TABLE artist
(
	artist_id int identity(1,1), 
	first_name varchar(100) NOT NULL, 
	last_name varchar(100) NOT NULL, 

	constraint pk_artist_id primary key(artist_id)
);

CREATE TABLE customers
(
	customer_id int identity(2000, 3),
	first_name varchar(100) NOT NULL, 
	last_name varchar(100) NOT NULL, 
	address varchar (200) NOT NULL,

	constraint pk_customer_id primary key(customer_id)
);

CREATE TABLE artwork
(
	art_id int identity(1, 1),
	title varchar(200) DEFAULT 'Untitled' NOT NULL,
	artist_id int NOT NULL

	constraint pk_art_id primary key(art_id),
	constraint fk_art_arist_id foreign key(artist_id) references artist(artist_id)
);

CREATE TABLE transactions
(
	transaction_id int identity(1, 1) NOT NULL, 
	artwork_id int NOT NULL,
	purchase_date datetime NOT NULL,
	price money NOT null, 

	constraint pk_transaction_id primary key(transaction_id),
	constraint fk_transaction_artwork foreign key (artwork_id) references artwork (art_id),
	constraint fk_transaction_customer foreign key (customer_id) references customers (customer_id)
);

INSERT INTO customers (first_name, last_name, address)
VALUES ('George', 'Foreman', '1600 Pennsylvania Ave')

INSERT INTO customers (first_name, last_name, address)
VALUES ('George', 'Foreman ii', '1600 Pennsylvania Ave')

SELECT * from customers
