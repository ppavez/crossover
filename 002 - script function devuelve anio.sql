create or replace FUNCTION obtenerAnio(p_fecha DATE)  
 
RETURN NUMBER 
 
IS 
 
 
v_anio  NUMBER := 0; 
 
BEGIN         
 
    SELECT EXTRACT(YEAR FROM p_fecha) INTO v_anio FROM dual;
 
 
RETURN v_anio; 
 
EXCEPTION 
 
        WHEN OTHERS 
 
            THEN 
 
                RETURN 0;                 
 
END obtenerAnio; 
/