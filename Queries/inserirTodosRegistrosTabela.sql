INSERT INTO mantis_project_table (id, name, status, enabled, view_state, access_min, file_path, description, category_id, inherit_global) VALUES
	(908, 'Test OBJ Project', 10, 1, 10, 10, '/tmp/', 'Open Baking', 1, 1);
	
	
INSERT INTO mantis_bug_table
( project_id, reporter_id, handler_id, duplicate_id, priority, severity, reproducibility, status, resolution, projection, eta, bug_text_id, os, os_build, platform, version, fixed_in_version, build, profile_id, view_state, summary, sponsorship_total, sticky, target_version, category_id, date_submitted, due_date, last_updated)
VALUES(13, 2, 1, 0, 0, 0, 50, 10, 10, 10, 10, 10, 13, '', '', '', '', '', '', 0, 10, 'Desafio Testes APIQV', 0, 0, '', 2, 1576783454, 1, 1576783640);

INSERT INTO mantis_filters_table (id, user_id, project_id, is_public, name, filter_string) VALUES
(1, 1, 0, 0, 'Teste 1', 'v9#{\"_version\":\"v9\",\"_view_type\":\"simple\",\"category_id\":[\"0\"],\"severity\":[0],\"status\":[0],\"highlight_changed\":6,\"reporter_id\":[0],\"handler_id\":[0],\"project_id\":[-3],\"resolution\":[0],\"build\":[\"0\"],\"version\":[\"0\"],\"hide_status\":[90],\"monitor_user_id\":[0],\"sort\":\"last_updated\",\"dir\":\"DESC\",\"per_page\":50,\"match_type\":0,\"platform\":[\"0\"],\"os\":[\"0\"],\"os_build\":[\"0\"],\"fixed_in_version\":[\"0\"],\"target_version\":[\"0\"],\"profile_id\":[0],\"priority\":[0],\"note_user_id\":[0],\"sticky\":true,\"filter_by_date\":false,\"start_month\":\"02\",\"end_month\":\"02\",\"start_day\":1,\"end_day\":\"01\",\"start_year\":\"2020\",\"end_year\":\"2020\",\"filter_by_last_updated_date\":false,\"last_updated_start_month\":\"02\",\"last_updated_end_month\":\"02\",\"last_updated_start_day\":1,\"last_updated_end_day\":\"01\",\"last_updated_start_year\":\"2020\",\"last_updated_end_year\":\"2020\",\"search\":\"\",\"view_state\":0,\"tag_string\":\"\",\"tag_select\":0,\"relationship_type\":-1,\"relationship_bug\":0,\"custom_fields\":[]}');

INSERT INTO mantis_user_table (id, username, realname, email, password, enabled, protected, access_level, login_count, lost_password_request_count, failed_login_count, cookie_string, last_visit, date_created) VALUES
(46, 'Tales SFUH', 'talesCXZSZ', 'tales@teste09.com', '', 1, 0, 40, 0, 0, 0, '', 1580596874, 1580596874);



INSERT INTO mantis_bug_history_table (id, user_id, bug_id, field_name, old_value, new_value, type, date_modified) VALUES
(58, 1, 13, '', '', '', 1, 1576783454);


INSERT INTO mantis_project_version_table (id, project_id, version, description, released, obsolete, date_order) VALUES
(1, 2, 'v1.0.0', '', 1, 1, 1576764531);