S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 13643
Date: 2016-06-12 12:05:23-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8c0

Register Information
r0   = 0xbeec2300, r1   = 0xbeec21a0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbeec2568, r5   = 0xbeec2300
r6   = 0x00000132, r7   = 0xbeec22b0
r8   = 0xb6c189c0, r9   = 0xb7a21ff8
r10  = 0xb6c26b18, fp   = 0x0000017e
ip   = 0xb5ace38c, sp   = 0xbeec2160
lr   = 0xb5ac5dcf, pc   = 0x000008c0
cpsr = 0xa0000010

Memory Information
MemTotal:   391348 KB
MemFree:     50188 KB
Buffers:      3436 KB
Cached:      66716 KB
VmPeak:      73256 KB
VmSize:      72712 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14348 KB
VmRSS:       14348 KB
VmData:      21332 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 13643 TID = 13643
13643 13779 13785 

Maps Information
b2bb6000 b33b5000 rwxp [stack:13785]
b3450000 b3467000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3474000 b34fb000 rw-s anon_inode:dmabuf
b34fb000 b3506000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b350f000 b3511000 r-xp /usr/lib/libgenlock.so
b3524000 b3527000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3530000 b3d2f000 rwxp [stack:13779]
b3f2f000 b3f36000 r-xp /usr/lib/libtbm.so.1.0.0
b3f3e000 b3f40000 r-xp /usr/lib/libdri2.so.0.0.0
b3f48000 b3f4d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f55000 b3f5d000 r-xp /usr/lib/libdrm.so.2.4.0
b3f65000 b3f6e000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3f77000 b3f83000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3f8b000 b3f94000 r-xp /usr/lib/libcom-core.so.0.0.1
b5524000 b552a000 r-xp /usr/lib/libwidget.so.1.0.0
b5533000 b5539000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b5541000 b5625000 r-xp /usr/lib/libicuuc.so.51.1
b563a000 b5777000 r-xp /usr/lib/libicui18n.so.51.1
b5787000 b5794000 r-xp /usr/lib/libalarm.so.0.0.0
b579d000 b57a4000 r-xp /usr/lib/libappcore-watch.so.1.1
b594c000 b5956000 r-xp /lib/libnss_files-2.13.so
b595f000 b5a2e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a44000 b5a68000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5a71000 b5a77000 r-xp /usr/lib/libappsvc.so.0.1.0
b5a7f000 b5a81000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5a8a000 b5a8e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5aa0000 b5aa5000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5aad000 b5aaf000 r-xp /usr/lib/libiniparser.so.0
b5ab8000 b5abd000 r-xp /usr/lib/libappcore-common.so.1.1
b5ac5000 b5ac7000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5acf000 b5ad3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5ae0000 b5ae2000 r-xp /usr/lib/libXau.so.6.0.0
b5aeb000 b5af2000 r-xp /lib/libcrypt-2.13.so
b5b22000 b5b24000 r-xp /usr/lib/libiri.so
b5b2c000 b5cd4000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ced000 b5d3a000 r-xp /usr/lib/libssl.so.1.0.0
b5d47000 b5d75000 r-xp /usr/lib/libidn.so.11.5.44
b5d7d000 b5d86000 r-xp /usr/lib/libcares.so.2.1.0
b5d8f000 b5da2000 r-xp /usr/lib/libxcb.so.1.1.0
b5dab000 b5dad000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5db6000 b5db8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5dc1000 b5e8d000 r-xp /usr/lib/libxml2.so.2.7.8
b5e9a000 b5e9c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5ea4000 b5ea9000 r-xp /usr/lib/libffi.so.5.0.10
b5eb1000 b5eb2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5ebb000 b5ec6000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5ece000 b5ed1000 r-xp /lib/libattr.so.1.1.0
b5ed9000 b5f6d000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f80000 b5f9d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5fa6000 b5fbe000 r-xp /usr/lib/libpng12.so.0.50.0
b5fc7000 b5fdd000 r-xp /lib/libexpat.so.1.5.2
b5fe7000 b602b000 r-xp /usr/lib/libcurl.so.4.3.0
b6034000 b603e000 r-xp /usr/lib/libXext.so.6.4.0
b6047000 b604b000 r-xp /usr/lib/libXtst.so.6.1.0
b6053000 b6059000 r-xp /usr/lib/libXrender.so.1.3.0
b6062000 b6068000 r-xp /usr/lib/libXrandr.so.2.2.0
b6070000 b6071000 r-xp /usr/lib/libXinerama.so.1.0.0
b607a000 b6083000 r-xp /usr/lib/libXi.so.6.1.0
b608b000 b608e000 r-xp /usr/lib/libXfixes.so.3.1.0
b6096000 b6098000 r-xp /usr/lib/libXgesture.so.7.0.0
b60a0000 b60a2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b60ab000 b60ad000 r-xp /usr/lib/libXdamage.so.1.1.0
b60b5000 b60bc000 r-xp /usr/lib/libXcursor.so.1.0.2
b60c4000 b60c7000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60cf000 b60d3000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60dc000 b60e1000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60eb000 b61cc000 r-xp /usr/lib/libX11.so.6.3.0
b61d7000 b61fa000 r-xp /usr/lib/libjpeg.so.8.0.2
b6212000 b6228000 r-xp /lib/libz.so.1.2.5
b6230000 b62a5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b62af000 b62c5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b62ce000 b6302000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b630b000 b63de000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b63e9000 b63f9000 r-xp /lib/libresolv-2.13.so
b63fd000 b6479000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6485000 b649d000 r-xp /usr/lib/liblzma.so.5.0.3
b64a6000 b64a9000 r-xp /lib/libcap.so.2.21
b64b1000 b64de000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b64e6000 b64e7000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b64ef000 b64f5000 r-xp /usr/lib/libecore_imf.so.1.7.99
b64fd000 b6514000 r-xp /usr/lib/liblua-5.1.so
b651e000 b6525000 r-xp /usr/lib/libembryo.so.1.7.99
b652d000 b6533000 r-xp /lib/librt-2.13.so
b653c000 b6592000 r-xp /usr/lib/libpixman-1.so.0.28.2
b659f000 b65f5000 r-xp /usr/lib/libfreetype.so.6.11.3
b6601000 b6629000 r-xp /usr/lib/libfontconfig.so.1.8.0
b662b000 b6668000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6671000 b6684000 r-xp /usr/lib/libfribidi.so.0.3.1
b668c000 b66a6000 r-xp /usr/lib/libecore_con.so.1.7.99
b66af000 b66b8000 r-xp /usr/lib/libedbus.so.1.7.99
b66c0000 b6710000 r-xp /usr/lib/libecore_x.so.1.7.99
b6713000 b6717000 r-xp /usr/lib/libvconf.so.0.2.45
b671f000 b6730000 r-xp /usr/lib/libecore_input.so.1.7.99
b6738000 b673d000 r-xp /usr/lib/libecore_file.so.1.7.99
b6745000 b6767000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6770000 b67b1000 r-xp /usr/lib/libeina.so.1.7.99
b67ba000 b67d3000 r-xp /usr/lib/libeet.so.1.7.99
b67e4000 b684d000 r-xp /lib/libm-2.13.so
b6856000 b685c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6865000 b6868000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6870000 b6892000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b689a000 b689f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68a7000 b68d1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68da000 b68f1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b68f9000 b6904000 r-xp /lib/libunwind.so.8.0.1
b6931000 b696d000 r-xp /usr/lib/libsystemd.so.0.4.0
b6976000 b6a91000 r-xp /lib/libc-2.13.so
b6a9f000 b6aa7000 r-xp /lib/libgcc_s-4.6.so.1
b6aa8000 b6aab000 r-xp /usr/lib/libsmack.so.1.0.0
b6ab3000 b6ab9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ac1000 b6b91000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6b92000 b6bef000 r-xp /usr/lib/libedje.so.1.7.99
b6bf9000 b6c10000 r-xp /usr/lib/libecore.so.1.7.99
b6c27000 b6cf5000 r-xp /usr/lib/libevas.so.1.7.99
b6d1a000 b6e55000 r-xp /usr/lib/libelementary.so.1.7.99
b6e6b000 b6e7f000 r-xp /lib/libpthread-2.13.so
b6e8a000 b6e8c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e94000 b6e97000 r-xp /usr/lib/libbundle.so.0.1.22
b6e9f000 b6ea1000 r-xp /lib/libdl-2.13.so
b6eaa000 b6eb6000 r-xp /usr/lib/libaul.so.0.1.0
b6ec8000 b6ecd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed6000 b6eda000 r-xp /usr/lib/libsys-assert.so
b6ee3000 b6f00000 r-xp /lib/ld-2.13.so
b6f09000 b6f0e000 r-xp /usr/bin/launchpad-loader
b79e9000 b7bb0000 rw-p [heap]
beea2000 beec3000 rwxp [stack]
beea2000 beec3000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13643)
Call Stack Count: 1
 0: (0x8c0) (null)
End of Call Stack

Package Information
Package Name: org.example.decimalwatch
Package ID : org.example.decimalwatch
Version: 1.0.0
Package Type: rpm
App Name: decimalwatch
App ID: org.example.decimalwatch
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
:881> sendKeepAliveThread() - presSendNotify(0) end
06-12 12:05:03.222-0500 W/SCSD    (11611): <_keepalive_cb:520> entrance
06-12 12:05:03.222-0500 W/SCSD    (11611): <util_tel_set_ps_dormant:9> request GoDormantAll
06-12 12:05:03.332-0500 W/SNL_W   (11611): <sendKeepAliveAllGroup:731> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
06-12 12:05:03.332-0500 W/SNL_W   (11611): <setAlarm:520> setAlarm() - begin 
06-12 12:05:03.332-0500 W/SNL_W   (11611): <initAlarm:505> InitAlarm() - begin
06-12 12:05:03.332-0500 W/SNL_W   (11611): <initAlarm:511> InitAlarm() success - end
06-12 12:05:03.352-0500 I/AUL     (11611): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.382-0500 I/AUL     (11611): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.382-0500 E/ALARM_MANAGER(11611): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(715), start(12-6-2016, 12:16:58), repeat(0), interval(0), type(-1073741822)
06-12 12:05:03.392-0500 W/ALARM_MANAGER(  886): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
06-12 12:05:03.392-0500 W/ALARM_MANAGER(  886): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
06-12 12:05:03.412-0500 I/AUL     (  886): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.432-0500 I/AUL     (  886): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.442-0500 I/AUL     (  886): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.452-0500 I/AUL     (  886): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.452-0500 W/ALARM_MANAGER(  886): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
06-12 12:05:03.452-0500 W/ALARM_MANAGER(  886): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
06-12 12:05:03.462-0500 I/AUL     (  886): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.472-0500 I/AUL     (  886): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1465751818, Sun Jun 12 12:16:58 2016
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1066294756, next duetime: 1465751818
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1066294756)
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1465793472), due_time(1465751818)
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 12-6-2016, 17:16:58 (UTC).
06-12 12:05:03.472-0500 E/ALARM_MANAGER(  886): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-12 12:05:03.472-0500 W/SNL_W   (11611): <setAlarm:569> setAlarm() - end : mStatus ( 1 ) currentInterval( 720 ) interruptFlag ( 0 ) alarm_id ( 1066294756 )
06-12 12:05:03.472-0500 W/SNL_W   (11611): <sendKeepAliveAllGroup:750> sendKeepAliveAllGroup() - set last interval ( 480 )
06-12 12:05:03.472-0500 W/SNL_W   (11611): <util_pm_unlock:1154> util_pm_unlock() UNLOCK
06-12 12:05:03.472-0500 W/SNL_W   (11611): <sendKeepAliveAllGroup:756> sendKeepAliveAllGroup () - WakeLock release
06-12 12:05:03.472-0500 W/SNL_W   (11611): <sendKeepAliveAllGroup:768> sendKeepAliveAllGroup() - end Error ( 0 )
06-12 12:05:03.532-0500 W/SNL_W   (11611): <releaseWakeLockinTimeThread:813> releaseWakeLockinTimeThread () - WakeLock already released
06-12 12:05:03.992-0500 I/CAPI_WATCH_APPLICATION(13617): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:04.992-0500 I/CAPI_WATCH_APPLICATION(13617): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:05.992-0500 I/CAPI_WATCH_APPLICATION(13617): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:06.652-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 12:05:06.712-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0xad4eb100 -> 360 0 0xaea29388
06-12 12:05:06.722-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 12:05:06.722-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
06-12 12:05:06.722-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 12:05:06.722-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.722-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.732-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 12:05:06.742-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.742-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.752-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.752-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.762-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.762-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.772-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 12:05:06.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.802-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.802-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.812-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.812-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.832-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.832-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.852-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.852-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.862-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.862-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.882-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:06.882-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:06.882-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 12:05:06.882-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(3)
06-12 12:05:06.902-0500 W/WATCH_CORE(13617): appcore-watch.c: __widget_pause(1001) > widget_pause
06-12 12:05:07.002-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 12:05:07.362-0500 E/EFL     ( 1272): evas_main<1272> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
06-12 12:05:07.362-0500 E/EFL     ( 1272): evas_main<1272> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
06-12 12:05:07.362-0500 E/EFL     ( 1272): evas_main<1272> evas_object_main.c:1368 evas_object_color_set() Evas only handles pre multiplied colors!
06-12 12:05:07.392-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0xaea29388 -> 360 0 0xaeaaaa60
06-12 12:05:07.392-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 12:05:07.392-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.392-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.422-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.422-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.432-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.432-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.442-0500 W/WATCH_CORE(13617): appcore-watch.c: __widget_resume(1012) > widget_resume
06-12 12:05:07.442-0500 I/CAPI_WATCH_APPLICATION(13617): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:07.462-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-12 12:05:07.462-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.462-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.462-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.462-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.492-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.492-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.502-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.502-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.512-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
06-12 12:05:07.512-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 12:05:07.512-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.512-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.522-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 12:05:07.522-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.522-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.542-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.542-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.562-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.562-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.572-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:07.572-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:07.582-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 12:05:07.582-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(2)
06-12 12:05:07.712-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 12:05:07.992-0500 I/CAPI_WATCH_APPLICATION(13617): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:08.052-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: main(2131) > package manager server start
06-12 12:05:08.082-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 12:05:08.142-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_-971187010], req_type=[12], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[], cookie=[y/JHMcfdrMRnsdkMwDiZ9a3IeSk=], backend_flag=[0]
06-12 12:05:08.152-0500 E/PKGMGR_SERVER(13777): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.decimalwatch]
06-12 12:05:08.162-0500 E/PKGMGR  (13774): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.decimalwatch, -1]
06-12 12:05:08.242-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.252-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13617
06-12 12:05:08.252-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 12:05:08.262-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 12:05:08.262-0500 E/AUL_AMD (  926): amd_request.c: __app_process_by_pid(193) > pid(12393) is dead. cmd(5) is canceled
06-12 12:05:08.262-0500 E/PKGMGR_SERVER(13777): pkgmgr-server.c: __terminate_app(1393) > [0;31m[__terminate_app(): 1393](ret < 0) aul_terminate_pid[-3] fail
06-12 12:05:08.262-0500 E/PKGMGR_SERVER(13777): [0;m
06-12 12:05:08.262-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 12:05:08.262-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(13617), cmd(4)
06-12 12:05:08.262-0500 W/CAPI_WATCH_APPLICATION(13617): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
06-12 12:05:08.262-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 22
06-12 12:05:08.262-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(890) > app status : 4
06-12 12:05:08.262-0500 W/WATCH_CORE(13617): appcore-watch.c: __widget_destroy(992) > widget_destory
06-12 12:05:08.262-0500 E/WIDGET_PROVIDER_APP(13617): client.c: client_fini(1175) > Provider is not initialized
06-12 12:05:08.262-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.272-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13617
06-12 12:05:08.272-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 4
06-12 12:05:08.322-0500 E/AUL_AMD (  926): amd_launch.c: __reply_handler(898) > recv error : Connection reset by peer
06-12 12:05:08.322-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(13617), cmd(4)
06-12 12:05:08.322-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 0
06-12 12:05:08.332-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 12:05:08.342-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 12:05:08.342-0500 E/AUL_AMD (  926): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
06-12 12:05:08.342-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(1708) > caller pid : 1122
06-12 12:05:08.382-0500 E/RESOURCED(  928): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.decimalwatch, table num : 7
06-12 12:05:08.392-0500 E/RESOURCED(  928): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-12 12:05:08.392-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(2086) > pad pid(-5)
06-12 12:05:08.392-0500 W/AUL_PAD ( 1664): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
06-12 12:05:08.392-0500 W/AUL_PAD ( 1664): launchpad.c: __send_result_to_caller(272) > Check app launching
06-12 12:05:08.422-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: watch_app_main(382) > watch_app_main
06-12 12:05:08.502-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.502-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:08.502-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13617
06-12 12:05:08.502-0500 E/AUL     (  926): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-12 12:05:08.532-0500 W/WATCH_CORE(13643): appcore-watch.c: __widget_create(958) > widget_create
06-12 12:05:08.532-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1712) > [SECURE_LOG] [80620.210938] pkgname: org.example.decimalwatch, id: file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_80620.210938.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://18874472:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
06-12 12:05:08.532-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[80620.210938] pkgname[org.example.decimalwatch], id[file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_80620.210938.png] content[] cluster[user,created] category[default] widget_fname[pixmap://18874472:4] gbar_fname[]
06-12 12:05:08.552-0500 E/WIDGET_VIEWER( 1166): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
06-12 12:05:08.552-0500 E/WIDGET_EVAS( 1166): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
06-12 12:05:08.602-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.612-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:08.622-0500 W/WATCH_CORE(13643): appcore-watch.c: __widget_create(976) > widget_create done
06-12 12:05:08.682-0500 I/WATCH_CORE(13643): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
06-12 12:05:08.682-0500 I/WATCH_CORE(13643): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
06-12 12:05:08.682-0500 I/WATCH_CORE(13643): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
06-12 12:05:08.712-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.722-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:08.832-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.832-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:08.942-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:08.942-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.042-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.052-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.152-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.162-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.262-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.262-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.372-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.372-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.472-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.482-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.492-0500 W/AUL_AMD (  926): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-12 12:05:09.492-0500 W/AUL_AMD (  926): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
06-12 12:05:09.512-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.522-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.522-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 12:05:09.582-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.592-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.632-0500 E/EFL     (13795): elementary<13795> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 12:05:09.632-0500 E/EFL     (13795): elementary<13795> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 12:05:09.652-0500 E/EFL     (13795): elementary<13795> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 12:05:09.652-0500 E/EFL     (13795): elementary<13795> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 12:05:09.682-0500 E/EFL     (13795): elementary<13795> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 12:05:09.682-0500 E/EFL     (13795): elementary<13795> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 12:05:09.682-0500 E/EFL     (13795): elementary<13795> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 12:05:09.682-0500 E/EFL     (13795): elementary<13795> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 12:05:09.682-0500 E/EFL     (13795): elementary<13795> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 12:05:09.692-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.702-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.712-0500 E/EFL     (13795): elementary<13795> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 12:05:09.712-0500 E/EFL     (13795): elementary<13795> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 12:05:09.712-0500 E/EFL     (13795): elementary<13795> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 12:05:09.742-0500 E/EFL     (13795): elementary<13795> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 12:05:09.742-0500 I/AUL_PAD (13795): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 12:05:09.812-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.812-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:09.922-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:09.942-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.042-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.062-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.172-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.192-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.262-0500 W/AUL_AMD (  926): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
06-12 12:05:10.292-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.322-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.382-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 12:05:10.432-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.452-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.562-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.582-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.692-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.712-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.822-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.842-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:10.952-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:10.972-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.082-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.102-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.212-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.222-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.332-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.342-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.442-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.472-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.572-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.592-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.692-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.712-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.822-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.842-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:11.942-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:11.972-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.072-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.102-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.202-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.232-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.342-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.362-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.382-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 12:05:12.462-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.482-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.592-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.612-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.722-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.742-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.852-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.862-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:12.972-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:12.972-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.082-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.112-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.222-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.242-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.342-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.352-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.462-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.482-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.592-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.612-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.722-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.742-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.852-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:13.872-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:13.982-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:14.002-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:14.112-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:14.132-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:14.232-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:14.252-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:14.362-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 12:05:14.382-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13643
06-12 12:05:14.382-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 12:05:14.502-0500 E/PKGMGR_SERVER(13777): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
06-12 12:05:14.542-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: sighandler(409) > child NORMAL exit [13777]
06-12 12:05:15.812-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 12:05:15.852-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0xad4eb100 -> 360 0 0xaea29388
06-12 12:05:15.872-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 12:05:15.882-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
06-12 12:05:15.882-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 12:05:15.892-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.892-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:15.892-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 12:05:15.902-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 12:05:15.912-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.912-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:15.922-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.922-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:15.942-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.942-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:15.952-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.952-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:15.972-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.972-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:15.992-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:15.992-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:16.002-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:16.002-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:16.032-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:16.032-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:16.052-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:16.052-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:16.072-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:16.072-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:16.082-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 12:05:16.082-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(3)
06-12 12:05:16.092-0500 W/WATCH_CORE(13643): appcore-watch.c: __widget_pause(1001) > widget_pause
06-12 12:05:16.122-0500 E/WATCH_CORE(13643): appcore-watch.c: __do_app(322) > Invalid state
06-12 12:05:16.202-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 12:05:16.382-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 12:05:16.382-0500 E/PKGMGR_SERVER(13776): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 12:05:16.582-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 12:05:17.292-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0xaea29388 -> 360 0 0xaeaaaa60
06-12 12:05:17.322-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 12:05:17.322-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.322-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.332-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.332-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.352-0500 W/WATCH_CORE(13643): appcore-watch.c: __widget_resume(1012) > widget_resume
06-12 12:05:17.352-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:17.352-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 12:05:17.352-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.352-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.362-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.362-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.382-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.382-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.392-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.392-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.412-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.412-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.422-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
06-12 12:05:17.422-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 12:05:17.422-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.422-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.432-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 12:05:17.442-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.442-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.462-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 12:05:17.462-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 12:05:17.492-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 12:05:17.492-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(2)
06-12 12:05:17.622-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 12:05:17.992-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:18.002-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 12:05:19.002-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:19.992-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:20.992-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:21.652-0500 E/PKGMGR  (13889): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 12:05:21.782-0500 E/PKGMGR_SERVER(13895): pkgmgr-server.c: main(2131) > package manager server start
06-12 12:05:21.892-0500 E/PKGMGR_SERVER(13895): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_-957359932], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_-957359932' '-r' 'org.example.decimalwatch'], cookie=[tpF4Rkl7mzvyASOEBZNYEjOYmiQ=], backend_flag=[0]
06-12 12:05:21.892-0500 E/PKGMGR  (13895): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 12:05:21.892-0500 E/PKGMGR_SERVER(13895): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 12:05:21.902-0500 E/PKGMGR  (13889): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[138890002]
06-12 12:05:21.902-0500 E/PKGMGR_SERVER(13897): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 12:05:21.992-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:22.172-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 12:05:22.182-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 12:05:22.182-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 12:05:22.192-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 12:05:22.402-0500 W/CERT_SVC(13897): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
06-12 12:05:22.452-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-12 12:05:22.462-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 12:05:22.472-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 131
06-12 12:05:22.472-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 131
06-12 12:05:22.472-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 54 1
06-12 12:05:22.472-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 55 1
06-12 12:05:22.472-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 56 1
06-12 12:05:22.472-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 57 1
06-12 12:05:22.492-0500 E/PKGMGR_CERT(13897): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-12 12:05:22.732-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13795
06-12 12:05:22.832-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13616
06-12 12:05:22.922-0500 E/EFL     (13900): elementary<13900> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 12:05:22.932-0500 E/EFL     (13900): elementary<13900> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 12:05:22.972-0500 E/EFL     (13900): elementary<13900> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 12:05:22.972-0500 E/EFL     (13900): elementary<13900> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 12:05:22.992-0500 I/CAPI_WATCH_APPLICATION(13643): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 12:05:23.002-0500 E/EFL     (13900): elementary<13900> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 12:05:23.012-0500 E/EFL     (13900): elementary<13900> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 12:05:23.012-0500 E/EFL     (13900): elementary<13900> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 12:05:23.012-0500 E/EFL     (13900): elementary<13900> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 12:05:23.012-0500 E/EFL     (13900): elementary<13900> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 12:05:23.022-0500 E/EFL     (13900): elementary<13900> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 12:05:23.042-0500 E/EFL     (13900): elementary<13900> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 12:05:23.042-0500 E/EFL     (13900): elementary<13900> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 12:05:23.072-0500 E/EFL     (13900): elementary<13900> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 12:05:23.072-0500 I/AUL_PAD (13900): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 12:05:23.332-0500 W/CRASH_MANAGER(13902): worker.c: worker_job(1199) > 1113643646563146575112
