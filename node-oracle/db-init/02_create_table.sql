connect TEST_USER/test_user@//localhost:1521/xe;

create table numbers (
  my_number integer not null
);

commit;
exit;
