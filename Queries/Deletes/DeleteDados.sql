--DELETE TBL.MANTIS_PROJECT_TABLE
DELETE FROM mantis_project_table WHERE ID = 908;

--DELETE TBL.mantis_bug_table
DELETE FROM mantis_bug_table WHERE ID = 13;

--DELETE TBL.mantis_filters_table
DELETE FROM mantis_filters_table WHERE ID = 1;

--DELETE TBL.mantis_user_table
DELETE FROM mantis_user_table WHERE ID = 46;

--DELETE TBL.mantis_bug_history_table
DELETE FROM mantis_bug_history_table WHERE ID = 58;

--DELETE TBL.mantis_project_version_table
DELETE FROM mantis_project_version_table WHERE date_order = 1576764531;

--DELETE TBL.mantis_user_table
DELETE FROM mantis_user_table where email = "jair_melo@hotmail.com";