S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 11999
Date: 2016-06-12 11:56:48-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1a7

Register Information
r0   = 0x0000019b, r1   = 0x0000000d
r2   = 0x0000000b, r3   = 0xb5b4f194
r4   = 0x0000019b, r5   = 0x00000000
r6   = 0xb7ac9564, r7   = 0xb7abb008
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6f91dc0
ip   = 0xbeacfc7c, sp   = 0xbeacfc30
lr   = 0xb6f770d0, pc   = 0xb6f769dc
cpsr = 0x20000010

Memory Information
MemTotal:   391348 KB
MemFree:     18080 KB
Buffers:      5216 KB
Cached:      75132 KB
VmPeak:      73060 KB
VmSize:      72516 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14088 KB
VmRSS:       14088 KB
VmData:      21136 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11999 TID = 11999
11999 12253 12263 

Maps Information
b2c40000 b343f000 rwxp [stack:12263]
b34da000 b34f1000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b34fe000 b3585000 rw-s anon_inode:dmabuf
b3585000 b3590000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3599000 b359b000 r-xp /usr/lib/libgenlock.so
b35ae000 b35b1000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b35ba000 b3db9000 rwxp [stack:12253]
b3fb9000 b3fc0000 r-xp /usr/lib/libtbm.so.1.0.0
b3fc8000 b3fca000 r-xp /usr/lib/libdri2.so.0.0.0
b3fd2000 b3fd7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fdf000 b3fe7000 r-xp /usr/lib/libdrm.so.2.4.0
b3fef000 b3ff8000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4001000 b400d000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4015000 b401e000 r-xp /usr/lib/libcom-core.so.0.0.1
b55ae000 b55b4000 r-xp /usr/lib/libwidget.so.1.0.0
b55bd000 b55c3000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b55cb000 b56af000 r-xp /usr/lib/libicuuc.so.51.1
b56c4000 b5801000 r-xp /usr/lib/libicui18n.so.51.1
b5811000 b581e000 r-xp /usr/lib/libalarm.so.0.0.0
b5827000 b582e000 r-xp /usr/lib/libappcore-watch.so.1.1
b59d6000 b59e0000 r-xp /lib/libnss_files-2.13.so
b59e9000 b5ab8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5ace000 b5af2000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5afb000 b5b01000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b09000 b5b0b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b14000 b5b18000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b2a000 b5b2f000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b37000 b5b39000 r-xp /usr/lib/libiniparser.so.0
b5b42000 b5b47000 r-xp /usr/lib/libappcore-common.so.1.1
b5b4f000 b5b51000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5b59000 b5b5d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b6a000 b5b6c000 r-xp /usr/lib/libXau.so.6.0.0
b5b75000 b5b7c000 r-xp /lib/libcrypt-2.13.so
b5bac000 b5bae000 r-xp /usr/lib/libiri.so
b5bb6000 b5d5e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d77000 b5dc4000 r-xp /usr/lib/libssl.so.1.0.0
b5dd1000 b5dff000 r-xp /usr/lib/libidn.so.11.5.44
b5e07000 b5e10000 r-xp /usr/lib/libcares.so.2.1.0
b5e19000 b5e2c000 r-xp /usr/lib/libxcb.so.1.1.0
b5e35000 b5e37000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e40000 b5e42000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e4b000 b5f17000 r-xp /usr/lib/libxml2.so.2.7.8
b5f24000 b5f26000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f2e000 b5f33000 r-xp /usr/lib/libffi.so.5.0.10
b5f3b000 b5f3c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f45000 b5f50000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f58000 b5f5b000 r-xp /lib/libattr.so.1.1.0
b5f63000 b5ff7000 r-xp /usr/lib/libstdc++.so.6.0.16
b600a000 b6027000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6030000 b6048000 r-xp /usr/lib/libpng12.so.0.50.0
b6051000 b6067000 r-xp /lib/libexpat.so.1.5.2
b6071000 b60b5000 r-xp /usr/lib/libcurl.so.4.3.0
b60be000 b60c8000 r-xp /usr/lib/libXext.so.6.4.0
b60d1000 b60d5000 r-xp /usr/lib/libXtst.so.6.1.0
b60dd000 b60e3000 r-xp /usr/lib/libXrender.so.1.3.0
b60ec000 b60f2000 r-xp /usr/lib/libXrandr.so.2.2.0
b60fa000 b60fb000 r-xp /usr/lib/libXinerama.so.1.0.0
b6104000 b610d000 r-xp /usr/lib/libXi.so.6.1.0
b6115000 b6118000 r-xp /usr/lib/libXfixes.so.3.1.0
b6120000 b6122000 r-xp /usr/lib/libXgesture.so.7.0.0
b612a000 b612c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6135000 b6137000 r-xp /usr/lib/libXdamage.so.1.1.0
b613f000 b6146000 r-xp /usr/lib/libXcursor.so.1.0.2
b614e000 b6151000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6159000 b615d000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6166000 b616b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6175000 b6256000 r-xp /usr/lib/libX11.so.6.3.0
b6261000 b6284000 r-xp /usr/lib/libjpeg.so.8.0.2
b629c000 b62b2000 r-xp /lib/libz.so.1.2.5
b62ba000 b632f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6339000 b634f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6358000 b638c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6395000 b6468000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6473000 b6483000 r-xp /lib/libresolv-2.13.so
b6487000 b6503000 r-xp /usr/lib/libgcrypt.so.20.0.3
b650f000 b6527000 r-xp /usr/lib/liblzma.so.5.0.3
b6530000 b6533000 r-xp /lib/libcap.so.2.21
b653b000 b6568000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6570000 b6571000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6579000 b657f000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6587000 b659e000 r-xp /usr/lib/liblua-5.1.so
b65a8000 b65af000 r-xp /usr/lib/libembryo.so.1.7.99
b65b7000 b65bd000 r-xp /lib/librt-2.13.so
b65c6000 b661c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6629000 b667f000 r-xp /usr/lib/libfreetype.so.6.11.3
b668b000 b66b3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66b5000 b66f2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66fb000 b670e000 r-xp /usr/lib/libfribidi.so.0.3.1
b6716000 b6730000 r-xp /usr/lib/libecore_con.so.1.7.99
b6739000 b6742000 r-xp /usr/lib/libedbus.so.1.7.99
b674a000 b679a000 r-xp /usr/lib/libecore_x.so.1.7.99
b679d000 b67a1000 r-xp /usr/lib/libvconf.so.0.2.45
b67a9000 b67ba000 r-xp /usr/lib/libecore_input.so.1.7.99
b67c2000 b67c7000 r-xp /usr/lib/libecore_file.so.1.7.99
b67cf000 b67f1000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67fa000 b683b000 r-xp /usr/lib/libeina.so.1.7.99
b6844000 b685d000 r-xp /usr/lib/libeet.so.1.7.99
b686e000 b68d7000 r-xp /lib/libm-2.13.so
b68e0000 b68e6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68ef000 b68f2000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68fa000 b691c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6924000 b6929000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6931000 b695b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6964000 b697b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6983000 b698e000 r-xp /lib/libunwind.so.8.0.1
b69bb000 b69f7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a00000 b6b1b000 r-xp /lib/libc-2.13.so
b6b29000 b6b31000 r-xp /lib/libgcc_s-4.6.so.1
b6b32000 b6b35000 r-xp /usr/lib/libsmack.so.1.0.0
b6b3d000 b6b43000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b4b000 b6c1b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c1c000 b6c79000 r-xp /usr/lib/libedje.so.1.7.99
b6c83000 b6c9a000 r-xp /usr/lib/libecore.so.1.7.99
b6cb1000 b6d7f000 r-xp /usr/lib/libevas.so.1.7.99
b6da4000 b6edf000 r-xp /usr/lib/libelementary.so.1.7.99
b6ef5000 b6f09000 r-xp /lib/libpthread-2.13.so
b6f14000 b6f16000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1e000 b6f21000 r-xp /usr/lib/libbundle.so.0.1.22
b6f29000 b6f2b000 r-xp /lib/libdl-2.13.so
b6f34000 b6f40000 r-xp /usr/lib/libaul.so.0.1.0
b6f52000 b6f57000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f60000 b6f64000 r-xp /usr/lib/libsys-assert.so
b6f6d000 b6f8a000 r-xp /lib/ld-2.13.so
b6f93000 b6f98000 r-xp /usr/bin/launchpad-loader
b79c9000 b7b5f000 rw-p [heap]
beab0000 bead1000 rwxp [stack]
beab0000 bead1000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11999)
Call Stack Count: 6
 0: (0xb6f769dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6f770d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6f77360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6f7b5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6f81a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb6a6d70c) [/lib/libc.so.6] + 0x6d70c
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
E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:43.602-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:56:43.602-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(767) > [_dynamic_bluetooth_state_changed_cb:767] isBTOn : 0
06-12 11:56:43.602-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(773) > [_dynamic_bluetooth_state_changed_cb:773] sap connected : 1
06-12 11:56:43.602-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(779) > [_dynamic_bluetooth_state_changed_cb:779] sap connectivity type : 16
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:43.602-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:43.622-0500 I/W_INDICATOR( 1114): windicator_brightness.c: _current_device_brightness_level_get(142) > [_current_device_brightness_level_get:142] Brightness level : 80
06-12 11:56:43.622-0500 E/W_INDICATOR( 1114): windicator_volume.c: _current_device_volume_level_get(220) > [_current_device_volume_level_get:220] Failed to get volume by sound manager (return value : -1)
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_call_fwd_btn.c: windicator_call_fwd_btn_update(258) > [windicator_call_fwd_btn_update:258] 
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
06-12 11:56:43.622-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(95) > [windicator_scs_update:95] svc type : 1
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
06-12 11:56:43.622-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 2
06-12 11:56:43.622-0500 I/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
06-12 11:56:43.632-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
06-12 11:56:43.632-0500 E/EFL     (  605): <605> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
06-12 11:56:43.642-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
06-12 11:56:43.642-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:56:43.652-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1113) > [_ecore_event_client_message_cb:1113] quickpanel 0
06-12 11:56:43.652-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(960) > [_ecore_event_client_message_cb:960] quickpanel is closed
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:56:43.652-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:56:43.652-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 11:56:43.652-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.windicator]register msg port [false][0m
06-12 11:56:43.652-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _mp_messageport_register(324) > [_mp_messageport_register:324] Used message-port
06-12 11:56:43.652-0500 E/MESSAGE_PORT( 1114): message_port.cpp: message_port_unregister_local_port(123) > [MESSAGE_PORT_ERROR_PORT_NOT_FOUND] The local port ID (7) is not registered.
06-12 11:56:43.652-0500 E/W_INDICATOR( 1114): windicator_message_port.c: windicator_message_port_fini(354) > [windicator_message_port_fini:354] Failed to unregister music service message port cb
06-12 11:56:43.652-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_hide(1531) > [windicator_moment_bar_hide:1531] Hide Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:56:43.652-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb132d4e0, elm_layout, _activated_obj : 0x0, activated : 0
06-12 11:56:43.652-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 11:56:43.652-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb132d4e0, elm_layout, func : 0xb6eeb729
06-12 11:56:43.652-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 11:56:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-12 11:56:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-12 11:56:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-12 11:56:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-12 11:56:44.382-0500 E/PKGMGR_SERVER(12364): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:56:44.602-0500 E/rpm-installer(12370): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
06-12 11:56:45.322-0500 E/GESTURE (  260): gesture.c: GestureHandleButtonPressEvent(3375) > root_y=34   flick_area=45 ---> SET value to 1
06-12 11:56:45.322-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
06-12 11:56:45.322-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:56:45.322-0500 E/GESTURE (  260): gesture.c: GestureHandleButtonPressEvent(3375) > root_y=34   flick_area=45 ---> SET value to 1
06-12 11:56:45.332-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:1
06-12 11:56:45.332-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:56:45.332-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1091) > [_ecore_event_client_message_cb:1091] quickpanel 1
06-12 11:56:45.332-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_show(1377) > [windicator_moment_bar_show:1377] Show Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:56:45.332-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:56:45.332-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(301) > [_windi_sim_state_set:301] service_type(1) spn_disp_cond(0)
06-12 11:56:45.332-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(378) > [_windi_sim_state_set:378] text : (No service)
06-12 11:56:45.332-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_localized_txt_get(236) > [_windi_sim_state_localized_txt_get:236] 
06-12 11:56:45.332-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_localized_txt_get(274) > [_windi_sim_state_localized_txt_get:274] is_mapped : 1
06-12 11:56:45.332-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(382) > [_windi_sim_state_set:382] localize text : No service
06-12 11:56:45.332-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(403) > [_windi_sim_state_set:403] plmn : (No service)
06-12 11:56:45.342-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 8/5, (0xb1346cc8)
06-12 11:56:45.342-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(878) > [_rssi_icon_set:878] Set RSSI SHOW sw.icon_0 (rssi_level : 8) (rssi_hide : 1)(b1346cc8)
06-12 11:56:45.342-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_verizon_No_signal
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 9/5, (0xb1346cc8)
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(873) > [_rssi_icon_set:873] Set RSSI HIDE sw.icon_0 (rssi_level : 9) (rssi_hide : 0)
06-12 11:56:45.352-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_none
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 9/5, (0xb7cf0b48)
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(873) > [_rssi_icon_set:873] Set RSSI HIDE sw.icon_0 (rssi_level : 9) (rssi_hide : 1)
06-12 11:56:45.352-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_none
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: windi_sim_state_remove(599) > [windi_sim_state_remove:599] 
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_type_changed_cb(1052) > [_connection_type_changed_cb:1052] wifi state : 2
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_type_changed_cb(1054) > [_connection_type_changed_cb:1054] 
06-12 11:56:45.352-0500 I/W_INDICATOR( 1114): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 10 / signal : type_wifi_connected_01
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 10) / (hide : 0)
06-12 11:56:45.352-0500 I/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(607) > [_connection_icon_set:607] 3G option : (1)
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(620) > [_connection_icon_set:620] EMERGENCY CB : (0)
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(628) > [_connection_icon_set:628] Dnet off :: Dim signal : type_wifi_connected_01 / 3G option on,off: (1)
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:45.352-0500 I/W_INDICATOR( 1114): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 10 / signal : type_wifi_connected_01
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 10) / (hide : 0)
06-12 11:56:45.352-0500 I/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(607) > [_connection_icon_set:607] 3G option : (1)
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(620) > [_connection_icon_set:620] EMERGENCY CB : (0)
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(628) > [_connection_icon_set:628] Dnet off :: Dim signal : type_wifi_connected_01 / 3G option on,off: (1)
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(767) > [_dynamic_bluetooth_state_changed_cb:767] isBTOn : 0
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(773) > [_dynamic_bluetooth_state_changed_cb:773] sap connected : 1
06-12 11:56:45.352-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(779) > [_dynamic_bluetooth_state_changed_cb:779] sap connectivity type : 16
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:45.352-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:45.372-0500 I/W_INDICATOR( 1114): windicator_brightness.c: _current_device_brightness_level_get(142) > [_current_device_brightness_level_get:142] Brightness level : 80
06-12 11:56:45.372-0500 E/W_INDICATOR( 1114): windicator_volume.c: _current_device_volume_level_get(220) > [_current_device_volume_level_get:220] Failed to get volume by sound manager (return value : -1)
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_call_fwd_btn.c: windicator_call_fwd_btn_update(258) > [windicator_call_fwd_btn_update:258] 
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
06-12 11:56:45.372-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(95) > [windicator_scs_update:95] svc type : 1
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
06-12 11:56:45.372-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 2
06-12 11:56:45.372-0500 I/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
06-12 11:56:45.372-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
06-12 11:56:45.372-0500 E/EFL     (  605): <605> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
06-12 11:56:45.382-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
06-12 11:56:45.382-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:56:45.392-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1113) > [_ecore_event_client_message_cb:1113] quickpanel 0
06-12 11:56:45.392-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(960) > [_ecore_event_client_message_cb:960] quickpanel is closed
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:56:45.392-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:56:45.392-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _mp_messageport_register(324) > [_mp_messageport_register:324] Used message-port
06-12 11:56:45.392-0500 E/MESSAGE_PORT( 1114): message_port.cpp: message_port_unregister_local_port(123) > [MESSAGE_PORT_ERROR_PORT_NOT_FOUND] The local port ID (7) is not registered.
06-12 11:56:45.392-0500 E/W_INDICATOR( 1114): windicator_message_port.c: windicator_message_port_fini(354) > [windicator_message_port_fini:354] Failed to unregister music service message port cb
06-12 11:56:45.392-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_hide(1531) > [windicator_moment_bar_hide:1531] Hide Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:56:45.392-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb132d4e0, elm_layout, _activated_obj : 0x0, activated : 0
06-12 11:56:45.392-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 11:56:45.392-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb132d4e0, elm_layout, func : 0xb6eeb729
06-12 11:56:45.392-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 11:56:45.392-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 11:56:45.392-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.windicator]register msg port [false][0m
06-12 11:56:46.382-0500 E/PKGMGR_SERVER(12364): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:56:47.762-0500 E/GESTURE (  260): gesture.c: GestureHandleButtonPressEvent(3375) > root_y=34   flick_area=45 ---> SET value to 1
06-12 11:56:47.762-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
06-12 11:56:47.762-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:56:47.762-0500 E/GESTURE (  260): gesture.c: GestureHandleButtonPressEvent(3375) > root_y=34   flick_area=45 ---> SET value to 1
06-12 11:56:47.772-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:1
06-12 11:56:47.772-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:56:47.772-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1091) > [_ecore_event_client_message_cb:1091] quickpanel 1
06-12 11:56:47.772-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_show(1377) > [windicator_moment_bar_show:1377] Show Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:56:47.772-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:56:47.772-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(301) > [_windi_sim_state_set:301] service_type(1) spn_disp_cond(0)
06-12 11:56:47.772-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(378) > [_windi_sim_state_set:378] text : (No service)
06-12 11:56:47.772-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_localized_txt_get(236) > [_windi_sim_state_localized_txt_get:236] 
06-12 11:56:47.772-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_localized_txt_get(274) > [_windi_sim_state_localized_txt_get:274] is_mapped : 1
06-12 11:56:47.772-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(382) > [_windi_sim_state_set:382] localize text : No service
06-12 11:56:47.772-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(403) > [_windi_sim_state_set:403] plmn : (No service)
06-12 11:56:47.782-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 8/5, (0xb1346cc8)
06-12 11:56:47.782-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(878) > [_rssi_icon_set:878] Set RSSI SHOW sw.icon_0 (rssi_level : 8) (rssi_hide : 1)(b1346cc8)
06-12 11:56:47.782-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_verizon_No_signal
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 9/5, (0xb1346cc8)
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(873) > [_rssi_icon_set:873] Set RSSI HIDE sw.icon_0 (rssi_level : 9) (rssi_hide : 0)
06-12 11:56:47.792-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_none
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 9/5, (0xb7cf0b48)
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(873) > [_rssi_icon_set:873] Set RSSI HIDE sw.icon_0 (rssi_level : 9) (rssi_hide : 1)
06-12 11:56:47.792-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_none
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: windi_sim_state_remove(599) > [windi_sim_state_remove:599] 
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_type_changed_cb(1052) > [_connection_type_changed_cb:1052] wifi state : 2
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_type_changed_cb(1054) > [_connection_type_changed_cb:1054] 
06-12 11:56:47.792-0500 I/W_INDICATOR( 1114): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 10 / signal : type_wifi_connected_01
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 10) / (hide : 0)
06-12 11:56:47.792-0500 I/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(607) > [_connection_icon_set:607] 3G option : (1)
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(620) > [_connection_icon_set:620] EMERGENCY CB : (0)
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(628) > [_connection_icon_set:628] Dnet off :: Dim signal : type_wifi_connected_01 / 3G option on,off: (1)
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:47.792-0500 I/W_INDICATOR( 1114): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 10 / signal : type_wifi_connected_01
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 10) / (hide : 0)
06-12 11:56:47.792-0500 I/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(607) > [_connection_icon_set:607] 3G option : (1)
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(620) > [_connection_icon_set:620] EMERGENCY CB : (0)
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(628) > [_connection_icon_set:628] Dnet off :: Dim signal : type_wifi_connected_01 / 3G option on,off: (1)
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(767) > [_dynamic_bluetooth_state_changed_cb:767] isBTOn : 0
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(773) > [_dynamic_bluetooth_state_changed_cb:773] sap connected : 1
06-12 11:56:47.792-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(779) > [_dynamic_bluetooth_state_changed_cb:779] sap connectivity type : 16
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:56:47.792-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:56:47.812-0500 I/W_INDICATOR( 1114): windicator_brightness.c: _current_device_brightness_level_get(142) > [_current_device_brightness_level_get:142] Brightness level : 80
06-12 11:56:47.812-0500 E/W_INDICATOR( 1114): windicator_volume.c: _current_device_volume_level_get(220) > [_current_device_volume_level_get:220] Failed to get volume by sound manager (return value : -1)
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_call_fwd_btn.c: windicator_call_fwd_btn_update(258) > [windicator_call_fwd_btn_update:258] 
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
06-12 11:56:47.812-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(95) > [windicator_scs_update:95] svc type : 1
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
06-12 11:56:47.812-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 2
06-12 11:56:47.812-0500 I/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
06-12 11:56:47.862-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
06-12 11:56:47.862-0500 E/EFL     (  605): <605> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
06-12 11:56:47.882-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
06-12 11:56:47.882-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:56:47.882-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1113) > [_ecore_event_client_message_cb:1113] quickpanel 0
06-12 11:56:47.882-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(960) > [_ecore_event_client_message_cb:960] quickpanel is closed
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:56:47.882-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:56:47.882-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 11:56:47.882-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.windicator]register msg port [false][0m
06-12 11:56:47.882-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _mp_messageport_register(324) > [_mp_messageport_register:324] Used message-port
06-12 11:56:47.882-0500 E/MESSAGE_PORT( 1114): message_port.cpp: message_port_unregister_local_port(123) > [MESSAGE_PORT_ERROR_PORT_NOT_FOUND] The local port ID (7) is not registered.
06-12 11:56:47.882-0500 E/W_INDICATOR( 1114): windicator_message_port.c: windicator_message_port_fini(354) > [windicator_message_port_fini:354] Failed to unregister music service message port cb
06-12 11:56:47.882-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_hide(1531) > [windicator_moment_bar_hide:1531] Hide Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:56:47.882-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb132d4e0, elm_layout, _activated_obj : 0x0, activated : 0
06-12 11:56:47.882-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 11:56:47.882-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb132d4e0, elm_layout, func : 0xb6eeb729
06-12 11:56:47.882-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 11:56:48.382-0500 E/PKGMGR_SERVER(12364): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:56:48.732-0500 E/PKGMGR_SERVER(12364): pkgmgr-server.c: sighandler(409) > child NORMAL exit [12370]
06-12 11:56:48.742-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:56:48.752-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.decimalwatch is updated, need to check validation
06-12 11:56:48.752-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.example.decimalwatch
06-12 11:56:48.772-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, COMPLETED]
06-12 11:56:48.772-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6915) > package install complete
06-12 11:56:48.772-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_package_install_event(4787) > 
06-12 11:56:48.772-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
06-12 11:56:48.912-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(249) > clock org.example.decimalwatch is updated, preload:0 update:0 event->update:0
06-12 11:56:48.952-0500 E/STARTER ( 1103): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
06-12 11:56:48.972-0500 E/PKGMGR_INFO(  891): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-12 11:56:48.982-0500 E/APPS    ( 1166): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
06-12 11:56:49.082-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:56:49.212-0500 W/CRASH_MANAGER(12378): worker.c: worker_job(1199) > 1111999646563146575060
