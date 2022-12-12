CREATE OR REPLACE PROCEDURE CountTable (IN wao character varying, INOUT numberOfLines integer)
LANGUAGE 'plpgsql'
AS $BODY$
    BEGIN
    EXECUTE 'Select count(*) From'|| quote_ident(wao) INTO numberOfLines;
    -- RAISE NOTICE 'count -> %', cnt;
    end;
$BODY$;
ALTER PROCEDURE CountTable(character varying, integer)
OWNER TO postgres;