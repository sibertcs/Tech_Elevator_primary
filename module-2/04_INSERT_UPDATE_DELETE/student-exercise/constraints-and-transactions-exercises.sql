
-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**
USE [dvdstore]
-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

BEGIN TRANSACTION

INSERT INTO actor (first_name, last_name)
VALUES ('Hampton', 'Avenue'), ('Lisa', 'Byway')

ROLLBACK TRANSACTION

SELECT *
FROM actor
WHERE first_name = 'Hampton' OR last_name = 'Byway'


-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

BEGIN TRANSACTION 

INSERT INTO film(title, description, release_year, language_id, length)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)

ROLLBACK TRANSACTION

SELECT *
FROM film
WHERE film_id = 1001

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

BEGIN TRANSACTION

INSERT INTO film_actor(actor_id, film_id)
VALUES ((SELECT actor_id FROM actor WHERE first_name = 'Hampton'), (SELECT film_id FROM film WHERE title = 'Euclidean PI')),
((SELECT actor_id FROM actor WHERE last_name = 'Byway'), (SELECT film_id FROM film WHERE title = 'Euclidean PI'))

ROLLBACK TRANSACTION

SELECT * 
FROM film_actor 
WHERE film_actor.film_id = 1001

-- 4. Add Mathmagical to the category table.

BEGIN TRANSACTION

INSERT INTO category(name)
VALUES ('Mathmagical')

ROLLBACK TRANSACTION

SELECT *
FROM category
WHERE name = 'Mathmagical'


-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

BEGIN TRANSACTION

INSERT INTO film_category(film_id, category_id)
VALUES (1001, 17)

UPDATE film_category
SET category_id = 17
WHERE film_id IN ((SELECT film_id FROM film WHERE title = 'Euclidean PI'), (SELECT film_id FROM film WHERE title = 'EGG IGBY'), 
	(SELECT film_id FROM film WHERE title = 'KARATE MOON'), (SELECT film_id FROM film WHERE title = 'RANDOM GO'), 
	(SELECT film_id FROM film WHERE title = 'YOUNG LANGUAGE')) 

ROLLBACK TRANSACTION

SELECT * 
FROM film
WHERE title = 'Euclidean PI'

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

BEGIN TRANSACTION
UPDATE film
SET rating = 'G'
FROM film
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON film_category.category_id = category.category_id
WHERE category.name = 'Mathmagical'

ROLLBACK TRANSACTION

-- 7. Add a copy of "Euclidean PI" to all the stores.

SELECT *
FROM store

INSERT INTO inventory (film_id, store_id)
VALUES (1001, 1), (1001, 2)


-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
BEGIN TRANSACTION
DELETE FROM film
WHERE title = 'Euclidean PI'
ROLLBACK TRANSACTION

--Did not succeed. It is referenced in the film.actor table where film_id is a PK.

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
BEGIN TRANSACTION
DELETE FROM category
WHERE name = 'Mathmagical'
ROLLBACK TRANSACTION

--Did not succeed. It is referenced in the film_category table where category_id is a PK

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
BEGIN TRANSACTION
DELETE FROM film_category
WHERE category_id = 17
ROLLBACK TRANSACTION

--Succeeded. category_id is both a PK and FK.


-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
BEGIN TRANSACTION
DELETE FROM category
WHERE name = 'Mathmagical'
ROLLBACK TRANSACTION

--Suceeded. No longer referenced in film_category. 

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

--DELETE references from film_actor and inventory tables 
