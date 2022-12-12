/*•	Вывести имена всех когда-либо обслуживаемых пассажиров авиакомпаний*/
SELECT name FROM public."Passenger";
/*•	Вывести названия всеx авиакомпаний*/
SELECT name FROM public."Company";
/*•	Вывести все рейсы, совершенные из Москвы*/
SELECT id, company, plane, town_from, town_to, time_out, time_in FROM public."Trip" WHERE town_from='Moscow';
/*•	Вывести имена людей, которые заканчиваются на "man"*/
SELECT name FROM public."Passenger" where name like '%man';
/*•	Вывести количество рейсов, совершенных на TU-134*/
SELECT id, company, plane, town_from, town_to, time_out, time_in FROM public."Trip" WHERE plane='TU-134';
/*•	Какие компании совершали перелеты на Boeing*/
SELECT name FROM public."Company" JOIN public."Trip" ON public."Company".ID = public."Trip".company AND public."Trip".plane = 'Boeing';
/*•	Вывести все названия самолётов, на которых можно улететь в Москву */
SELECT plane FROM public."Trip" WHERE town_to='Moscow';
/*•	В какие города можно улететь из Парижа (Paris) и сколько времени это займёт?*/
SELECT town_to ,time_out, time_in FROM public."Trip" WHERE town_from='Paris';
/*•	Какие компании организуют перелеты с Владивостока (Vladivostok)?*/
SELECT name FROM public."Company" JOIN public."Trip" ON public."Company".ID = public."Trip".company AND public."Trip".town_from='Vladivostok';
/*•	Вывести вылеты, совершенные с 10 ч. по 14 ч. 1 января 1900 г.*/
SELECT * FROM public."Trip" WHERE time_out BETWEEN '1900-01-01T10:00:00.000Z' AND '1900-01-01T14:00:00.000Z';
/*•	Вывести пассажиров с самым длинным именем*/
SELECT name FROM public. "Passenger" ORDER BY LENGTH(name) DESC LIMIT 1;
/*•	Вывести id и количество пассажиров для всех прошедших полётов*/
SELECT id, COUNT(id) FROM public."Trip" GROUP BY id;
/*•	Вывести имена людей, у которых есть полный тёзка среди пассажиров*/
SELECT name FROM public."Passenger" GROUP BY name HAVING COUNT(name) > 1;

/*В какие города летал Bruce Willis
SELECT town_to FROM public."Trip" 
JOIN public."Pass_in_trip" 
	ON public."Trip".id = public."Pass_in_trip".trip 
JOIN public."Passenger" 
	ON public."Pass_in_trip".passenger = public."Passenger".id WHERE name = 'Bruce Willis';*/

/*•	Во сколько Стив Мартин (Steve Martin) прилетел в Лондон (London)
SELECT time_in FROM public."Trip" 
JOIN public."Pass_in_trip" 
	ON public."Trip".id = public."Pass_in_trip".trip 
JOIN public."Passenger" 
	ON public."Pass_in_trip".passenger = public."Passenger".id WHERE name = 'Steve Martin' 
	AND town_to = 'London';*/

/*•	Вывести отсортированный по количеству перелетов (по убыванию) и имени (по возрастанию) список пассажиров, совершивших хотя бы 1 полет.
SELECT name, COUNT(*) AS count 
FROM public."Passenger" 
JOIN public."Pass_in_trip" ON public."Passenger".id = public."Pass_in_trip".passenger 
GROUP BY passenger HAVING COUNT(trip) > 0 ORDER BY COUNT(trip) DESC, name;*/

/*•	Сколько рейсов совершили авиакомпании с Ростова (Rostov) в Москву (Moscow) ?*/
SELECT count(company) FROM public."Trip" WHERE town_from='Rostov' and town_to='Moscow';
/*•	Выведите имена пассажиров улетевших в Москву (Moscow) на самолете TU-134*/
SELECT name FROM public."Passenger" JOIN public."Trip" ON public."Passenger".ID = public."Trip".company AND public."Trip".plane = 'TU-134';

/*•	Удалить компании, совершившие наименьшее количество рейсов.
DELETE FROM public."Company"
WHERE public."Company".id IN (
	SELECT public."Company" FROM public."Trip"
	GROUP BY public."Company" HAVING COUNT(id) = (SELECT MIN(count) FROM (SELECT COUNT(id) AS count FROM public."Trip" GROUP BY public."Company") AS min_count)
	);*/
/*•	Удалить все перелеты, совершенные из Москвы (Moscow).
DELETE FROM public."Trip" WHERE town_from='Moscow';*/
