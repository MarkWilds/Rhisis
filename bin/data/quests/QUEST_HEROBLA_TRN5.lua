QUEST_HEROBLA_TRN5 = {
	title = 'IDS_PROPQUEST_INC_001470',
	character = 'MaDa_Jeperdy',
	end_character = 'MaDa_Sencyrit',
	start_requirements = {
		min_level = 60,
		max_level = 60,
		job = { 'JOB_MERCENARY' },
	},
	rewards = {
		gold = 0,
	},
	end_conditions = {
		items = {
			{ id = 'II_SYS_SYS_QUE_VENHEART', quantity = 1, sex = 'Any', remove = true },
		},
		monsters = {
			{ id = 'MI_GUARDMON1', quantity = 1 },
		},
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_001471',
			'IDS_PROPQUEST_INC_001472',
			'IDS_PROPQUEST_INC_001473',
			'IDS_PROPQUEST_INC_001474',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_001475',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_001476',
		},
		completed = {
			'IDS_PROPQUEST_INC_001477',
			'IDS_PROPQUEST_INC_001478',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_001479',
		},
	}
}
