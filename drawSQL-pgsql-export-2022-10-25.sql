CREATE TABLE "Trip"(
    "id" INTEGER NOT NULL,
    "company" INTEGER NOT NULL,
    "plane" INTEGER NOT NULL,
    "town_from" INTEGER NOT NULL,
    "town_to" INTEGER NOT NULL,
    "time_out" INTEGER NOT NULL,
    "time_in" INTEGER NOT NULL
);
ALTER TABLE
    "Trip" ADD PRIMARY KEY("id");
CREATE TABLE "Pass_in_trip"(
    "id" INTEGER NOT NULL,
    "trip" INTEGER NOT NULL,
    "passenger" INTEGER NOT NULL,
    "place" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "Pass_in_trip" ADD PRIMARY KEY("id");
CREATE TABLE "Passenger"(
    "id" INTEGER NOT NULL,
    "name" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "Passenger" ADD PRIMARY KEY("id");
CREATE TABLE "Company"(
    "id" INTEGER NOT NULL,
    "name" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "Company" ADD PRIMARY KEY("id");
ALTER TABLE
    "Trip" ADD CONSTRAINT "trip_company_foreign" FOREIGN KEY("company") REFERENCES "Company"("id");
ALTER TABLE
    "Pass_in_trip" ADD CONSTRAINT "pass_in_trip_trip_foreign" FOREIGN KEY("trip") REFERENCES "Trip"("id");
ALTER TABLE
    "Pass_in_trip" ADD CONSTRAINT "pass_in_trip_passenger_foreign" FOREIGN KEY("passenger") REFERENCES "Passenger"("id");