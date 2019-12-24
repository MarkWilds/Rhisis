QUEST_HERORIN_TRN1 = {
	title = 'IDS_PROPQUEST_INC_001540',
	character = 'MaDa_Ellend',
	end_character = 'MaDa_Ellend',
	start_requirements = {
		min_level = 60,
		max_level = 60,
		job = { 'JOB_ASSIST' },
	},
	rewards = {
		gold = 0,
	},
	end_conditions = {
		monsters = {
			{ id = 'MI_DRILLER2', quantity = 20 },
		},
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_001541',
			'IDS_PROPQUEST_INC_001542',
			'IDS_PROPQUEST_INC_001543',
			'IDS_PROPQUEST_INC_001544',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_001545',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_001546',
		},
		completed = {
			'IDS_PROPQUEST_INC_001547',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_001548',
		},
	}
}
