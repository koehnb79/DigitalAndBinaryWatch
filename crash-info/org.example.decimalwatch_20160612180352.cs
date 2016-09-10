S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 22125
Date: 2016-06-12 18:03:52-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8c0

Register Information
r0   = 0xbef20300, r1   = 0xbef201a0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbef20568, r5   = 0xbef20300
r6   = 0x00000132, r7   = 0xbef202b0
r8   = 0xb6c9b9c0, r9   = 0xb73f7700
r10  = 0xb6ca9b18, fp   = 0x0000017e
ip   = 0xb5b51390, sp   = 0xbef20160
lr   = 0xb5b48dcf, pc   = 0x000008c0
cpsr = 0xa0000010

Memory Information
MemTotal:   391348 KB
MemFree:     21824 KB
Buffers:      4308 KB
Cached:      66404 KB
VmPeak:      73256 KB
VmSize:      72712 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14308 KB
VmRSS:       14308 KB
VmData:      21332 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 22125 TID = 22125
22125 22294 22300 

Maps Information
b2c39000 b3438000 rwxp [stack:22300]
b34d3000 b34ea000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b34f7000 b357e000 rw-s anon_inode:dmabuf
b357e000 b3589000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3592000 b3594000 r-xp /usr/lib/libgenlock.so
b35a7000 b35aa000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b35b3000 b3db2000 rwxp [stack:22294]
b3fb2000 b3fb9000 r-xp /usr/lib/libtbm.so.1.0.0
b3fc1000 b3fc3000 r-xp /usr/lib/libdri2.so.0.0.0
b3fcb000 b3fd0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fd8000 b3fe0000 r-xp /usr/lib/libdrm.so.2.4.0
b3fe8000 b3ff1000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3ffa000 b4006000 r-xp /usr/lib/libwidget_service.so.1.0.0
b400e000 b4017000 r-xp /usr/lib/libcom-core.so.0.0.1
b55a7000 b55ad000 r-xp /usr/lib/libwidget.so.1.0.0
b55b6000 b55bc000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b55c4000 b56a8000 r-xp /usr/lib/libicuuc.so.51.1
b56bd000 b57fa000 r-xp /usr/lib/libicui18n.so.51.1
b580a000 b5817000 r-xp /usr/lib/libalarm.so.0.0.0
b5820000 b5827000 r-xp /usr/lib/libappcore-watch.so.1.1
b59cf000 b59d9000 r-xp /lib/libnss_files-2.13.so
b59e2000 b5ab1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5ac7000 b5aeb000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5af4000 b5afa000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b02000 b5b04000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b0d000 b5b11000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b23000 b5b28000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b30000 b5b32000 r-xp /usr/lib/libiniparser.so.0
b5b3b000 b5b40000 r-xp /usr/lib/libappcore-common.so.1.1
b5b48000 b5b4a000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5b52000 b5b56000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b63000 b5b65000 r-xp /usr/lib/libXau.so.6.0.0
b5b6e000 b5b75000 r-xp /lib/libcrypt-2.13.so
b5ba5000 b5ba7000 r-xp /usr/lib/libiri.so
b5baf000 b5d57000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d70000 b5dbd000 r-xp /usr/lib/libssl.so.1.0.0
b5dca000 b5df8000 r-xp /usr/lib/libidn.so.11.5.44
b5e00000 b5e09000 r-xp /usr/lib/libcares.so.2.1.0
b5e12000 b5e25000 r-xp /usr/lib/libxcb.so.1.1.0
b5e2e000 b5e30000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e39000 b5e3b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e44000 b5f10000 r-xp /usr/lib/libxml2.so.2.7.8
b5f1d000 b5f1f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f27000 b5f2c000 r-xp /usr/lib/libffi.so.5.0.10
b5f34000 b5f35000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f3e000 b5f49000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f51000 b5f54000 r-xp /lib/libattr.so.1.1.0
b5f5c000 b5ff0000 r-xp /usr/lib/libstdc++.so.6.0.16
b6003000 b6020000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6029000 b6041000 r-xp /usr/lib/libpng12.so.0.50.0
b604a000 b6060000 r-xp /lib/libexpat.so.1.5.2
b606a000 b60ae000 r-xp /usr/lib/libcurl.so.4.3.0
b60b7000 b60c1000 r-xp /usr/lib/libXext.so.6.4.0
b60ca000 b60ce000 r-xp /usr/lib/libXtst.so.6.1.0
b60d6000 b60dc000 r-xp /usr/lib/libXrender.so.1.3.0
b60e5000 b60eb000 r-xp /usr/lib/libXrandr.so.2.2.0
b60f3000 b60f4000 r-xp /usr/lib/libXinerama.so.1.0.0
b60fd000 b6106000 r-xp /usr/lib/libXi.so.6.1.0
b610e000 b6111000 r-xp /usr/lib/libXfixes.so.3.1.0
b6119000 b611b000 r-xp /usr/lib/libXgesture.so.7.0.0
b6123000 b6125000 r-xp /usr/lib/libXcomposite.so.1.0.0
b612e000 b6130000 r-xp /usr/lib/libXdamage.so.1.1.0
b6138000 b613f000 r-xp /usr/lib/libXcursor.so.1.0.2
b6147000 b614a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6152000 b6156000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b615f000 b6164000 r-xp /usr/lib/libecore_fb.so.1.7.99
b616e000 b624f000 r-xp /usr/lib/libX11.so.6.3.0
b625a000 b627d000 r-xp /usr/lib/libjpeg.so.8.0.2
b6295000 b62ab000 r-xp /lib/libz.so.1.2.5
b62b3000 b6328000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6332000 b6348000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6351000 b6385000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b638e000 b6461000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b646c000 b647c000 r-xp /lib/libresolv-2.13.so
b6480000 b64fc000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6508000 b6520000 r-xp /usr/lib/liblzma.so.5.0.3
b6529000 b652c000 r-xp /lib/libcap.so.2.21
b6534000 b6561000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6569000 b656a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6572000 b6578000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6580000 b6597000 r-xp /usr/lib/liblua-5.1.so
b65a1000 b65a8000 r-xp /usr/lib/libembryo.so.1.7.99
b65b0000 b65b6000 r-xp /lib/librt-2.13.so
b65bf000 b6615000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6622000 b6678000 r-xp /usr/lib/libfreetype.so.6.11.3
b6684000 b66ac000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66ae000 b66eb000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66f4000 b6707000 r-xp /usr/lib/libfribidi.so.0.3.1
b670f000 b6729000 r-xp /usr/lib/libecore_con.so.1.7.99
b6732000 b673b000 r-xp /usr/lib/libedbus.so.1.7.99
b6743000 b6793000 r-xp /usr/lib/libecore_x.so.1.7.99
b6796000 b679a000 r-xp /usr/lib/libvconf.so.0.2.45
b67a2000 b67b3000 r-xp /usr/lib/libecore_input.so.1.7.99
b67bb000 b67c0000 r-xp /usr/lib/libecore_file.so.1.7.99
b67c8000 b67ea000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67f3000 b6834000 r-xp /usr/lib/libeina.so.1.7.99
b683d000 b6856000 r-xp /usr/lib/libeet.so.1.7.99
b6867000 b68d0000 r-xp /lib/libm-2.13.so
b68d9000 b68df000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68e8000 b68eb000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68f3000 b6915000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b691d000 b6922000 r-xp /usr/lib/libxdgmime.so.1.1.0
b692a000 b6954000 r-xp /usr/lib/libdbus-1.so.3.8.12
b695d000 b6974000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b697c000 b6987000 r-xp /lib/libunwind.so.8.0.1
b69b4000 b69f0000 r-xp /usr/lib/libsystemd.so.0.4.0
b69f9000 b6b14000 r-xp /lib/libc-2.13.so
b6b22000 b6b2a000 r-xp /lib/libgcc_s-4.6.so.1
b6b2b000 b6b2e000 r-xp /usr/lib/libsmack.so.1.0.0
b6b36000 b6b3c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b44000 b6c14000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c15000 b6c72000 r-xp /usr/lib/libedje.so.1.7.99
b6c7c000 b6c93000 r-xp /usr/lib/libecore.so.1.7.99
b6caa000 b6d78000 r-xp /usr/lib/libevas.so.1.7.99
b6d9d000 b6ed8000 r-xp /usr/lib/libelementary.so.1.7.99
b6eee000 b6f02000 r-xp /lib/libpthread-2.13.so
b6f0d000 b6f0f000 r-xp /usr/lib/libdlog.so.0.0.0
b6f17000 b6f1a000 r-xp /usr/lib/libbundle.so.0.1.22
b6f22000 b6f24000 r-xp /lib/libdl-2.13.so
b6f2d000 b6f39000 r-xp /usr/lib/libaul.so.0.1.0
b6f4b000 b6f50000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f59000 b6f5d000 r-xp /usr/lib/libsys-assert.so
b6f66000 b6f83000 r-xp /lib/ld-2.13.so
b6f8c000 b6f91000 r-xp /usr/bin/launchpad-loader
b73bf000 b7586000 rw-p [heap]
bef00000 bef21000 rwxp [stack]
bef00000 bef21000 rwxp [stack]
End of Maps Information

Callstack Information (PID:22125)
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
(0)
06-12 18:03:06.239-0500 W/W_HOME  ( 1166): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
06-12 18:03:06.239-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:03:06.239-0500 W/W_HOME  ( 1166): main.c: _window_visibility_cb(1200) > Window [0x2800003] is now visible(0)
06-12 18:03:06.239-0500 I/APP_CORE( 1166): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
06-12 18:03:06.239-0500 I/wnotib  ( 1166): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
06-12 18:03:06.239-0500 E/wnotib  ( 1166): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
06-12 18:03:06.239-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 18:03:06.709-0500 I/RESOURCED(  928): swap.c: swap_send_signal(594) > [swap_send_signal,594] send signal to swap thread
06-12 18:03:13.989-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-12 18:03:13.989-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-12 18:03:13.989-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-12 18:03:13.989-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-12 18:03:18.439-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: main(2131) > package manager server start
06-12 18:03:18.509-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_-955567062], req_type=[12], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[], cookie=[9+cQO/VOu+FfKV+3FnaGCnzKdIk=], backend_flag=[0]
06-12 18:03:18.919-0500 E/PKGMGR_SERVER(22291): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.decimalwatch]
06-12 18:03:18.939-0500 E/PKGMGR  (22283): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.decimalwatch, -1]
06-12 18:03:19.009-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.009-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13938
06-12 18:03:19.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 18:03:19.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 18:03:19.019-0500 E/AUL_AMD (  926): amd_request.c: __app_process_by_pid(193) > pid(13963) is dead. cmd(5) is canceled
06-12 18:03:19.019-0500 E/PKGMGR_SERVER(22291): pkgmgr-server.c: __terminate_app(1393) > [0;31m[__terminate_app(): 1393](ret < 0) aul_terminate_pid[-3] fail
06-12 18:03:19.019-0500 E/PKGMGR_SERVER(22291): [0;m
06-12 18:03:19.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 18:03:19.019-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(13938), cmd(4)
06-12 18:03:19.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.029-0500 W/CAPI_WATCH_APPLICATION(13938): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
06-12 18:03:19.029-0500 W/WATCH_CORE(13938): appcore-watch.c: __widget_destroy(992) > widget_destory
06-12 18:03:19.029-0500 E/WIDGET_PROVIDER_APP(13938): client.c: client_fini(1175) > Provider is not initialized
06-12 18:03:19.029-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13938
06-12 18:03:19.029-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 22
06-12 18:03:19.029-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(890) > app status : 4
06-12 18:03:19.029-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 4
06-12 18:03:19.089-0500 E/AUL_AMD (  926): amd_launch.c: __reply_handler(898) > recv error : Connection reset by peer
06-12 18:03:19.089-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(13938), cmd(4)
06-12 18:03:19.089-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 0
06-12 18:03:19.099-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:03:19.109-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:03:19.109-0500 E/AUL_AMD (  926): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
06-12 18:03:19.109-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(1708) > caller pid : 1122
06-12 18:03:19.119-0500 E/RESOURCED(  928): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.decimalwatch, table num : 7
06-12 18:03:19.119-0500 E/RESOURCED(  928): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-12 18:03:19.119-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(2086) > pad pid(-5)
06-12 18:03:19.119-0500 W/AUL_PAD ( 1664): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
06-12 18:03:19.119-0500 W/AUL_PAD ( 1664): launchpad.c: __send_result_to_caller(272) > Check app launching
06-12 18:03:19.149-0500 I/CAPI_WATCH_APPLICATION(22125): watch_app_main.c: watch_app_main(382) > watch_app_main
06-12 18:03:19.229-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.239-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.239-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13938
06-12 18:03:19.239-0500 E/AUL     (  926): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-12 18:03:19.269-0500 W/WATCH_CORE(22125): appcore-watch.c: __widget_create(958) > widget_create
06-12 18:03:19.269-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1712) > [SECURE_LOG] [80620.210938] pkgname: org.example.decimalwatch, id: file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_80620.210938.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://18874484:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
06-12 18:03:19.269-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[80620.210938] pkgname[org.example.decimalwatch], id[file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_80620.210938.png] content[] cluster[user,created] category[default] widget_fname[pixmap://18874484:4] gbar_fname[]
06-12 18:03:19.289-0500 E/WIDGET_VIEWER( 1166): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
06-12 18:03:19.289-0500 E/WIDGET_EVAS( 1166): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
06-12 18:03:19.339-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.349-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.389-0500 W/WATCH_CORE(22125): appcore-watch.c: __widget_create(976) > widget_create done
06-12 18:03:19.449-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.459-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.459-0500 I/WATCH_CORE(22125): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
06-12 18:03:19.459-0500 I/WATCH_CORE(22125): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
06-12 18:03:19.459-0500 I/WATCH_CORE(22125): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
06-12 18:03:19.559-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.569-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.669-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.669-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.779-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.779-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.879-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.889-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:19.999-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:19.999-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.099-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.109-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.209-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.219-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.229-0500 W/AUL_AMD (  926): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-12 18:03:20.229-0500 W/AUL_AMD (  926): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
06-12 18:03:20.249-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.259-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.259-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 18:03:20.309-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:03:20.319-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.329-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.419-0500 E/EFL     (22304): elementary<22304> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 18:03:20.419-0500 E/EFL     (22304): elementary<22304> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 18:03:20.429-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.439-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.439-0500 E/EFL     (22304): elementary<22304> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 18:03:20.449-0500 E/EFL     (22304): elementary<22304> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 18:03:20.479-0500 E/EFL     (22304): elementary<22304> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 18:03:20.479-0500 E/EFL     (22304): elementary<22304> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 18:03:20.479-0500 E/EFL     (22304): elementary<22304> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 18:03:20.479-0500 E/EFL     (22304): elementary<22304> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 18:03:20.479-0500 E/EFL     (22304): elementary<22304> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 18:03:20.499-0500 E/EFL     (22304): elementary<22304> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 18:03:20.499-0500 E/EFL     (22304): elementary<22304> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 18:03:20.499-0500 E/EFL     (22304): elementary<22304> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 18:03:20.529-0500 E/EFL     (22304): elementary<22304> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 18:03:20.539-0500 E/EFL     (22304): elementary<22304> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 18:03:20.539-0500 E/EFL     (22304): elementary<22304> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 18:03:20.539-0500 E/EFL     (22304): elementary<22304> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 18:03:20.539-0500 E/EFL     (22304): elementary<22304> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 18:03:20.539-0500 E/EFL     (22304): elementary<22304> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 18:03:20.539-0500 E/EFL     (22304): elementary<22304> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 18:03:20.539-0500 I/AUL_PAD (22304): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 18:03:20.539-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.549-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.649-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.659-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.759-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.779-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:20.889-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:20.909-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.039-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.039-0500 W/AUL_AMD (  926): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
06-12 18:03:21.139-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.169-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.279-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.309-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.409-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.439-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.539-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.569-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.669-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.699-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.799-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.829-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:21.939-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:21.959-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.069-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.089-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.199-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.219-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.309-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:03:22.329-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.349-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.459-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.479-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.589-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.609-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.719-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.739-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.849-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.869-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:22.969-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:22.999-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.109-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.129-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.239-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.259-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.369-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.379-0500 I/RESOURCED(  928): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
06-12 18:03:23.379-0500 I/RESOURCED(  928): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
06-12 18:03:23.389-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.499-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.519-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.629-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.669-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.769-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.789-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:23.899-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:23.909-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.009-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.039-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.149-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.169-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.279-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.299-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.309-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:03:24.409-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.429-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.539-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.559-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.669-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.689-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.799-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.819-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:24.929-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:24.949-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:25.059-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:25.079-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:25.179-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:25.209-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
06-12 18:03:25.329-0500 E/PKGMGR_SERVER(22291): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
06-12 18:03:25.359-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: sighandler(409) > child NORMAL exit [22291]
06-12 18:03:26.309-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 18:03:26.309-0500 E/PKGMGR_SERVER(22285): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 18:03:48.919-0500 W/WATCH_CORE(22125): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
06-12 18:03:48.919-0500 I/WATCH_CORE(22125): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
06-12 18:03:48.919-0500 W/wnotibp (13988): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_set(161) > timer set
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): gesture.c: _apps_status_get(123) > apps status:0
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:1 info->offtime:63035
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_schedule(211) > schedule, manual render
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): event_manager.c: _lcd_on_cb(691) > lcd state: 1
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(342) > appcore resumed manually
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): main.c: home_appcore_resume(710) > Home Appcore Resumed
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
06-12 18:03:48.929-0500 W/W_HOME  ( 1166): main.c: home_resume(735) > clock/widget resumed
06-12 18:03:48.939-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:03:48.939-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 18:03:48.939-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [powerkey] after screen off time [63035]ms
06-12 18:03:48.939-0500 W/STARTER ( 1103): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:03:48.939-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: RESUME State: RUNNING
06-12 18:03:48.949-0500 W/WATCH_CORE(22125): appcore-watch.c: __widget_resume(1012) > widget_resume
06-12 18:03:49.019-0500 I/CAPI_WATCH_APPLICATION(22125): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:03:49.019-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
06-12 18:03:49.019-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:03:49.029-0500 W/W_HOME  ( 1166): gesture.c: _widget_updated_cb(190) > widget updated
06-12 18:03:49.029-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:03:49.029-0500 W/W_HOME  ( 1166): gesture.c: _manual_render(176) > 
06-12 18:03:49.029-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
06-12 18:03:49.039-0500 W/W_HOME  ( 1166): gesture.c: _manual_render(176) > 
06-12 18:03:49.059-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [powerkey]
06-12 18:03:49.059-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:03:49.069-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(954) > [0;32mINFO: LCDOn receive data : -1226765556[0;m
06-12 18:03:49.069-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(955) > [0;32mINFO: WakeupServiceStart[0;m
06-12 18:03:49.069-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStart(371) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-12 18:03:49.069-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
06-12 18:03:49.079-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-12 18:03:49.079-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStart(390) > [0;32mINFO: 500[0;m
06-12 18:03:49.079-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:03:49.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:03:49.079-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_enable(133) > 0
06-12 18:03:49.089-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-12 18:03:49.089-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
06-12 18:03:49.099-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-12 18:03:49.099-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-12 18:03:49.099-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 1[0;m
06-12 18:03:49.099-0500 I/HIGEAR  ( 1551): WakeupService.cpp: WakeupServiceStart(395) > [svoice:Application:WakeupServiceStart:IN]
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:03:49.939-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:49.939-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:03:49.939-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [true][0m
06-12 18:03:49.989-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:49.999-0500 I/CAPI_WATCH_APPLICATION(22125): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:03:50.009-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:03:50.039-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:03:50.049-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1166
06-12 18:03:50.049-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:03:50.059-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:50.059-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:03:50.059-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:03:50.069-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:50.069-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:03:50.069-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:03:50.069-0500 I/TIZEN_N_SOUND_MANAGER( 1592): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-12 18:03:50.069-0500 W/TIZEN_N_SOUND_MANAGER( 1592): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:03:50.069-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:03:50.989-0500 I/CAPI_WATCH_APPLICATION(22125): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:03:51.159-0500 E/PKGMGR  (22403): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 18:03:51.279-0500 E/PKGMGR_SERVER(22409): pkgmgr-server.c: main(2131) > package manager server start
06-12 18:03:51.339-0500 E/PKGMGR_SERVER(22409): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_-922699345], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_-922699345' '-r' 'org.example.decimalwatch'], cookie=[fRBvN67OianyGAJ0pLUmlzSwVAE=], backend_flag=[0]
06-12 18:03:51.339-0500 E/PKGMGR  (22409): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 18:03:51.339-0500 E/PKGMGR_SERVER(22409): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 18:03:51.349-0500 E/PKGMGR  (22403): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[224030002]
06-12 18:03:51.349-0500 E/PKGMGR_SERVER(22411): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 18:03:51.559-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 18:03:51.559-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 18:03:51.559-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 18:03:51.569-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:03:51.749-0500 W/CERT_SVC(22411): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
06-12 18:03:51.789-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-12 18:03:51.799-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:03:51.809-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 131
06-12 18:03:51.809-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 131
06-12 18:03:51.809-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 54 1
06-12 18:03:51.809-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 55 1
06-12 18:03:51.809-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 56 1
06-12 18:03:51.809-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 57 1
06-12 18:03:51.819-0500 E/PKGMGR_CERT(22411): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-12 18:03:51.989-0500 I/CAPI_WATCH_APPLICATION(22125): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:03:52.029-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 22304
06-12 18:03:52.119-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 21972
06-12 18:03:52.269-0500 E/EFL     (22413): elementary<22413> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 18:03:52.269-0500 E/EFL     (22413): elementary<22413> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 18:03:52.299-0500 E/EFL     (22413): elementary<22413> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 18:03:52.299-0500 E/EFL     (22413): elementary<22413> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 18:03:52.369-0500 E/EFL     (22413): elementary<22413> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 18:03:52.369-0500 E/EFL     (22413): elementary<22413> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 18:03:52.369-0500 E/EFL     (22413): elementary<22413> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 18:03:52.369-0500 E/EFL     (22413): elementary<22413> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 18:03:52.369-0500 E/EFL     (22413): elementary<22413> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 18:03:52.439-0500 E/EFL     (22413): elementary<22413> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 18:03:52.459-0500 E/EFL     (22413): elementary<22413> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 18:03:52.459-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 22125
06-12 18:03:52.459-0500 E/EFL     (22413): elementary<22413> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 18:03:52.489-0500 W/CRASH_MANAGER(22415): worker.c: worker_job(1199) > 1122125646563146577263
