connect TEST_USER/test_user@//localhost:1521/xe;

insert into numbers(my_number) values(1);
insert into numbers(my_number) values(2);
insert into numbers(my_number) values(3);
insert into numbers(my_number) values(4);
insert into numbers(my_number) values(5);

commit;
exit;
