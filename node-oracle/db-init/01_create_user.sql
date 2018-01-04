create user TEST_USER identified by test_user;
grant connect, resource to TEST_USER;
alter user TEST_USER quota unlimited on users;

exit;
