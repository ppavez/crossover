create or replace procedure ap_reverse_number(input_no VARCHAR2) as
      output_no VARCHAR2(100);

    begin

      for i in 1 .. length(input_no) loop
        output_no := output_no || '' ||
                     substr(input_no, (length(input_no) - i + 1), 1);
      end loop;

      dbms_output.put_line('Input no. is :' || input_no);
      dbms_output.put_line('Output no. is:' || output_no);

    end;