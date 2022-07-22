
DELETE FROM mantis_project_table WHERE description = 'Novo dado';

DELETE FROM mantis_bug_table where bug_text_id = 128;

DELETE FROM mantis_filters_table WHERE USER_ID = 10;

DELETE FROM mantis_user_table WHERE EMAIL = 'tales@teste09.com';

DELETE FROM mantis_bug_history_table WHERE BUG_ID = 13;

DELETE FROM mantis_bugnote_table WHERE bugnote_text_id = 65;

DELETE  FROM mantis_project_version_table WHERE DESCRIPTION =  'Teste invalido';

DELETE FROM mantis_user_table where email = "jair_melo@hotmail.com";