using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DissDlcToolkit.Utils
{
    class UnicodeCodec
    {
        protected class CodecEntry {
		    public char[] symbol {get; set;}
		    public String stringData {get; set;}

		    public CodecEntry(char[] symbol, String stringData) {
			    this.symbol = symbol;
                this.stringData = stringData;
		    }
	    }

	    private CodecEntry[] symbols = new CodecEntry[] {
			    // Simple text
			    new CodecEntry(new char[] { '<' }, "=lt="),
			    new CodecEntry(new char[] { '>' }, "=gt="),
			    new CodecEntry(new char[] { '&' }, "=amp="),
			
			    // Symbols
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1601 }, "=equip_weapon_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1701 }, "=equip_hand_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1801 }, "=equip_head_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1901 }, "=equip_body_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2001 }, "=extra_ability_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2201 }, "=special_effect_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1201 }, "=stick_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0201 }, "=dpad_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2801 }, "=dpad_up_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2901 }, "=dpad_down_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2a01 }, "=dpad_left_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2b01 }, "=dpad_right_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2e01 }, "=triangle_1="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2f01 }, "=circle_1="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x3001 }, "=square_1="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x3101 }, "=x_1="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x8001 }, "=x_2="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x8101 }, "=circle_2="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2401, (char)0x001e, (char)0x2501 },"=select="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2601, (char)0x001e, (char)0x2701 },"=start="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2c01 }, "=l_top="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2d01 }, "=r_top="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1401 },"=artefact_nameless_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1501 }, "=artefact_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x2301 }, "=brv_bonus_icon="),
			
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221c }, "=job_freelance_icon="), //0x0015 negative acknowledge
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221d }, "=job_warrior_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221e }, "=job_monk_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2221 }, "=job_thief_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2222 }, "=job_dknight_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2223 }, "=job_dragoon_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2224 }, "=job_wmage_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2225 }, "=job_bmage_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2226 }, "=job_summoner_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2228 }, "=job_knight_icon="),			
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2229 }, "=job_samurai_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x222a }, "=job_berserker_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x222b }, "=job_mknight_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x222c }, "=job_ninja_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x222d }, "=job_sage_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2531 }, "=my_card_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2521 }, "=friend_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2529 }, "=special_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221a }, "=lock_card_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2412 }, "=shop_trade_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2211 }, "=shop_etc_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2439 }, "=manual_start_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2311 }, "=tutorial_new_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2321 }, "=stick_twd_foe_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2321 }, "=stick_twd_foe_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2324 }, "=stick_away_foe_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2331 }, "=stick_up_circle_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2333 }, "=stick_down_circle_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x228b }, "=branch_ability_icon="),
			
			    // Command chart icons
			    new CodecEntry(new char[] { (char)0x0015, (char)0x225b }, "=attack_crush_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2259 }, "=attack_block_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x225a }, "=attack_invincibility_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x225c }, "=attack_pull_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x225d }, "=attack_stg_destroy_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2254 }, "=attack_far_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2255 }, "=attack_near_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x225e }, "=attack_higher_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2261 }, "=attack_lower_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2262 }, "=high_brv_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2263 }, "=normal_brv_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2264 }, "=low_brv_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x224b }, "=tilt_up_stick_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x224c }, "=tilt_down_stick_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2256 }, "=tilt_twd_stick_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2257 }, "=tilt_away_stick_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2258 }, "=timing_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2251 }, "=succeed_block_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x224d }, "=press_repeat_button_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x224e }, "=press_hold_button_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2352 }, "=press_repeat_button_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2241 }, "=ground_weak_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2242 }, "=ground_med_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2243 }, "=ground_str_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2244 }, "=air_weak_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2245 }, "=air_med_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2246 }, "=air_str_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2247 }, "=circle_ground_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2248 }, "=circle_air_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2249 }, "=square_ground_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x224A }, "=square_air_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x228d }, "=x_ground_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x228e }, "=x_air_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2292 }, "=triangle_air_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2282 }, "=one_input_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2283 }, "=two_input_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2287 }, "=ex_only_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2286 }, "=switch_wp_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2384 }, "=ex_only_icon="),
			
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2217 }, "=basic_acc_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2218 }, "=booster_acc_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2219 }, "=special_acc_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221a }, "=trade_acc_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0d01 }, "=acc_rank_s_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0e01 }, "=acc_rank_a_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0f01 }, "=acc_rank_b_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1001 }, "=acc_rank_c_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0101 }, "=acc_boost_lv_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0301 }, "=acc_boost_hp_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0401 }, "=acc_boost_brv_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0501 }, "=acc_boost_ex_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0601 }, "=acc_boost_assist_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0701 }, "=acc_boost_action_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0801 }, "=acc_boost_status_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0901 }, "=acc_boost_location_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0a01 }, "=acc_boost_time_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x0b01 }, "=acc_boost_other_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1f01 }, "=summonstone_icon="),
			
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2265 }, "=summon_manual_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2266 }, "=summon_auto_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2268 }, "=summon_foe_auto_icon="),
			
			    new CodecEntry(new char[] { (char)0x0015, (char)0x226B }, "=assist_player_ground_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x226a }, "=assist_player_air_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x226e }, "=assist_opp_ground_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x226d }, "=assist_opp_air_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2269 }, "=assist_near_player_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x226c }, "=assist_near_opponent_icon="),
			
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2212 }, "=ap_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2213 }, "=gil_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2214 }, "=pp_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2215 }, "=exp_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2211 }, "=all_bonus_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1101 }, "=tent_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2215 }, "=start_point_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2219 }, "=location_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221a }, "=door_1_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221b }, "=door_2_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x221c }, "=door_3_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2216 }, "=tent_2_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2217 }, "=cottage_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2218 }, "=goal_point_labyrinth_icon="),
			    new CodecEntry(new char[] { (char)0x0015, (char)0x2211 }, "=start_point_labyrinth_icon="),
			
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1c01 }, "=battlegen_circle_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1b01 }, "=battlegen_square_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1e01 }, "=battlegen_break_icon="),
			    new CodecEntry(new char[] { (char)0x001e, (char)0x1d01 }, "=battlegen_rush_icon="),

			    // Variables
			    new CodecEntry(new char[] { (char)0x0013 }, "=menu_var="),
			    new CodecEntry(new char[] { (char)0x0019 }, "=ability_var="),
			    new CodecEntry(new char[] { (char)0x001A }, "=wireless_var_1="), //:substitute char
			    new CodecEntry(new char[] { (char)0x0018 }, "=wireless_var_2="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001D }, "=labyrinth_var="), //:group separator char
			    new CodecEntry(new char[] { (char)0x001f, (char)0x0003 }, "=mognet_playername="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'e' }, "=report_var_01="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'f' }, "=report_var_02="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'g' }, "=report_var_03="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'h' }, "=report_var_04="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'i' }, "=report_var_05="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'j' }, "=report_var_06="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'k' }, "=report_var_07="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'l' }, "=report_var_08="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'm' }, "=report_var_09="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'n' }, "=report_var_10="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'o' }, "=report_var_11="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'p' }, "=report_var_12="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'q' }, "=report_var_13="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'r' }, "=report_var_14="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 's' }, "=report_var_15="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 't' }, "=report_var_16="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'u' }, "=report_var_17="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'v' }, "=report_var_18="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'w' }, "=report_var_19="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'x' }, "=report_var_20="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'y' }, "=report_var_21="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, 'z' }, "=report_var_22="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, '{' }, "=report_var_23="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, '|' }, "=report_var_24="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f, '}' }, "=report_var_25="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f,  (char)0x007f }, "=report_var_26="), //:cancel char
			    new CodecEntry(new char[] { (char)0x001f }, "=report_var="), //:cancel char
			

			    // Text colors
			    new CodecEntry(new char[] { (char)0x0010, (char)0x8181, (char)0xFF01 }, "=text_yellow="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x8101, (char)0xFF81 }, "=text_blue="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0101, (char)0xFF81 }, "=text_dark_blue="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0101, (char)0xFF41 }, "=text_deep_blue="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0181, (char)0xFF01 }, "=text_red="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0141, (char)0xFF01 }, "=text_dark_red="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0141, (char)0xFF41 }, "=text_violet="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0181, (char)0xFF81 }, "=text_purple="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x619e, (char)0xFF01 }, "=text_gold="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x4101, (char)0xFF01 }, "=text_green="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x0181, (char)0xFF81 }, "=text_mog_2="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x6161, (char)0x6181 }, "=text_grey="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x4141, (char)0x4181 }, "=text_dark_grey="),
			    new CodecEntry(new char[] { (char)0x0010, (char)0x8181, (char)0xff81 }, "=text_white="),
			    new CodecEntry(new char[] { (char)0x001b }, "=text_end="), //color

			    // Text formats
			    new CodecEntry(new char[] { (char)0x0011, (char)0x0055 }, "=text_format_small_ability="),
			    new CodecEntry(new char[] { (char)0x0011, (char)0x0050 }, "=text_format_small_equipment="),
			    new CodecEntry(new char[] { (char)0x0011, (char)0x005a }, "=text_format_small_summons="),
			
			    new CodecEntry(new char[] { (char)0x0011, (char)0x0050 }, "=text_small_1="),
			    new CodecEntry(new char[] { (char)0x0011, (char)0x0040 }, "=text_small_2="),
			    new CodecEntry(new char[] { (char)0x0011, (char)0x0030 }, "=text_small_3="),
			
			
			    new CodecEntry(new char[] { (char)0x0011, (char)0x0064 }, "=text_format_end="), 
			
			    new CodecEntry(new char[] { (char)0x001e }, "=icon="),
			    new CodecEntry(new char[] { (char)0x0010 }, "=text_color="),
			    new CodecEntry(new char[] { (char)0x0015 }, "=icon_2="),
			    new CodecEntry(new char[] { (char)0x0001 }, "=soh="),
			    new CodecEntry(new char[] { (char)0x0000 }, "=null=")
	
	
	    };
	

	    public String escapeCharacters(String s) {
		    String symbol="";
		    try{
			    foreach (CodecEntry e in symbols) {
				    symbol = new String(e.symbol);
				    if (symbol.Contains("{") || symbol.Contains("}") || symbol.Contains("|"))
                    {
					    symbol = symbol.Replace(symbol, @symbol);					
				    }
				    s = s.Replace(symbol, e.stringData);
			    }
		    }
		    catch(Exception e){
			    Console.WriteLine(symbol);
                Logger.Log("AAA", e);
		    }
		    return s;
	    }

	    public String unescapeCharacters(String s) {
		    try{
			    foreach (CodecEntry e in symbols) {
				    s = s.Replace(e.stringData, new String(e.symbol));
			    }
			    return s;
		    }catch(Exception e){
                Console.WriteLine(s);
                Logger.Log("AAA", e);
		    }
		    return null;
	    }
    }
}
