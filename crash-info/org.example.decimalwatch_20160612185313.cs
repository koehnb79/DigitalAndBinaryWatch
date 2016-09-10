S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 24496
Date: 2016-06-12 18:53:13-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8c0

Register Information
r0   = 0xbeaaa300, r1   = 0xbeaaa0a0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbeaaa568, r5   = 0xbeaaa300
r6   = 0x00000132, r7   = 0xbeaaa2b0
r8   = 0xb6ce99c0, r9   = 0xb7050ff8
r10  = 0xb6cf7b18, fp   = 0x0000017e
ip   = 0xb5b9f3c0, sp   = 0xbeaaa060
lr   = 0xb5b96dd1, pc   = 0x000008c0
cpsr = 0xa0000010

Memory Information
MemTotal:   391348 KB
MemFree:     42296 KB
Buffers:      4296 KB
Cached:      71696 KB
VmPeak:      73388 KB
VmSize:      72844 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14600 KB
VmRSS:       14600 KB
VmData:      21464 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 24496 TID = 24496
24496 24827 24833 

Maps Information
b2c87000 b3486000 rwxp [stack:24833]
b3521000 b3538000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3545000 b35cc000 rw-s anon_inode:dmabuf
b35cc000 b35d7000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b35e0000 b35e2000 r-xp /usr/lib/libgenlock.so
b35f5000 b35f8000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3601000 b3e00000 rwxp [stack:24827]
b4000000 b4007000 r-xp /usr/lib/libtbm.so.1.0.0
b400f000 b4011000 r-xp /usr/lib/libdri2.so.0.0.0
b4019000 b401e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4026000 b402e000 r-xp /usr/lib/libdrm.so.2.4.0
b4036000 b403f000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4048000 b4054000 r-xp /usr/lib/libwidget_service.so.1.0.0
b405c000 b4065000 r-xp /usr/lib/libcom-core.so.0.0.1
b55f5000 b55fb000 r-xp /usr/lib/libwidget.so.1.0.0
b5604000 b560a000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b5612000 b56f6000 r-xp /usr/lib/libicuuc.so.51.1
b570b000 b5848000 r-xp /usr/lib/libicui18n.so.51.1
b5858000 b5865000 r-xp /usr/lib/libalarm.so.0.0.0
b586e000 b5875000 r-xp /usr/lib/libappcore-watch.so.1.1
b5a1d000 b5a27000 r-xp /lib/libnss_files-2.13.so
b5a30000 b5aff000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5b15000 b5b39000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b42000 b5b48000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b50000 b5b52000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b5b000 b5b5f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b71000 b5b76000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b7e000 b5b80000 r-xp /usr/lib/libiniparser.so.0
b5b89000 b5b8e000 r-xp /usr/lib/libappcore-common.so.1.1
b5b96000 b5b98000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5ba0000 b5ba4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5bb1000 b5bb3000 r-xp /usr/lib/libXau.so.6.0.0
b5bbc000 b5bc3000 r-xp /lib/libcrypt-2.13.so
b5bf3000 b5bf5000 r-xp /usr/lib/libiri.so
b5bfd000 b5da5000 r-xp /usr/lib/libcrypto.so.1.0.0
b5dbe000 b5e0b000 r-xp /usr/lib/libssl.so.1.0.0
b5e18000 b5e46000 r-xp /usr/lib/libidn.so.11.5.44
b5e4e000 b5e57000 r-xp /usr/lib/libcares.so.2.1.0
b5e60000 b5e73000 r-xp /usr/lib/libxcb.so.1.1.0
b5e7c000 b5e7e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e87000 b5e89000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e92000 b5f5e000 r-xp /usr/lib/libxml2.so.2.7.8
b5f6b000 b5f6d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f75000 b5f7a000 r-xp /usr/lib/libffi.so.5.0.10
b5f82000 b5f83000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f8c000 b5f97000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f9f000 b5fa2000 r-xp /lib/libattr.so.1.1.0
b5faa000 b603e000 r-xp /usr/lib/libstdc++.so.6.0.16
b6051000 b606e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6077000 b608f000 r-xp /usr/lib/libpng12.so.0.50.0
b6098000 b60ae000 r-xp /lib/libexpat.so.1.5.2
b60b8000 b60fc000 r-xp /usr/lib/libcurl.so.4.3.0
b6105000 b610f000 r-xp /usr/lib/libXext.so.6.4.0
b6118000 b611c000 r-xp /usr/lib/libXtst.so.6.1.0
b6124000 b612a000 r-xp /usr/lib/libXrender.so.1.3.0
b6133000 b6139000 r-xp /usr/lib/libXrandr.so.2.2.0
b6141000 b6142000 r-xp /usr/lib/libXinerama.so.1.0.0
b614b000 b6154000 r-xp /usr/lib/libXi.so.6.1.0
b615c000 b615f000 r-xp /usr/lib/libXfixes.so.3.1.0
b6167000 b6169000 r-xp /usr/lib/libXgesture.so.7.0.0
b6171000 b6173000 r-xp /usr/lib/libXcomposite.so.1.0.0
b617c000 b617e000 r-xp /usr/lib/libXdamage.so.1.1.0
b6186000 b618d000 r-xp /usr/lib/libXcursor.so.1.0.2
b6195000 b6198000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61a0000 b61a4000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61ad000 b61b2000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61bc000 b629d000 r-xp /usr/lib/libX11.so.6.3.0
b62a8000 b62cb000 r-xp /usr/lib/libjpeg.so.8.0.2
b62e3000 b62f9000 r-xp /lib/libz.so.1.2.5
b6301000 b6376000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6380000 b6396000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b639f000 b63d3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63dc000 b64af000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64ba000 b64ca000 r-xp /lib/libresolv-2.13.so
b64ce000 b654a000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6556000 b656e000 r-xp /usr/lib/liblzma.so.5.0.3
b6577000 b657a000 r-xp /lib/libcap.so.2.21
b6582000 b65af000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b65b7000 b65b8000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65c0000 b65c6000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65ce000 b65e5000 r-xp /usr/lib/liblua-5.1.so
b65ef000 b65f6000 r-xp /usr/lib/libembryo.so.1.7.99
b65fe000 b6604000 r-xp /lib/librt-2.13.so
b660d000 b6663000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6670000 b66c6000 r-xp /usr/lib/libfreetype.so.6.11.3
b66d2000 b66fa000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66fc000 b6739000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6742000 b6755000 r-xp /usr/lib/libfribidi.so.0.3.1
b675d000 b6777000 r-xp /usr/lib/libecore_con.so.1.7.99
b6780000 b6789000 r-xp /usr/lib/libedbus.so.1.7.99
b6791000 b67e1000 r-xp /usr/lib/libecore_x.so.1.7.99
b67e4000 b67e8000 r-xp /usr/lib/libvconf.so.0.2.45
b67f0000 b6801000 r-xp /usr/lib/libecore_input.so.1.7.99
b6809000 b680e000 r-xp /usr/lib/libecore_file.so.1.7.99
b6816000 b6838000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6841000 b6882000 r-xp /usr/lib/libeina.so.1.7.99
b688b000 b68a4000 r-xp /usr/lib/libeet.so.1.7.99
b68b5000 b691e000 r-xp /lib/libm-2.13.so
b6927000 b692d000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6936000 b6939000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6941000 b6963000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b696b000 b6970000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6978000 b69a2000 r-xp /usr/lib/libdbus-1.so.3.8.12
b69ab000 b69c2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69ca000 b69d5000 r-xp /lib/libunwind.so.8.0.1
b6a02000 b6a3e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a47000 b6b62000 r-xp /lib/libc-2.13.so
b6b70000 b6b78000 r-xp /lib/libgcc_s-4.6.so.1
b6b79000 b6b7c000 r-xp /usr/lib/libsmack.so.1.0.0
b6b84000 b6b8a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b92000 b6c62000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c63000 b6cc0000 r-xp /usr/lib/libedje.so.1.7.99
b6cca000 b6ce1000 r-xp /usr/lib/libecore.so.1.7.99
b6cf8000 b6dc6000 r-xp /usr/lib/libevas.so.1.7.99
b6deb000 b6f26000 r-xp /usr/lib/libelementary.so.1.7.99
b6f3c000 b6f50000 r-xp /lib/libpthread-2.13.so
b6f5b000 b6f5d000 r-xp /usr/lib/libdlog.so.0.0.0
b6f65000 b6f68000 r-xp /usr/lib/libbundle.so.0.1.22
b6f70000 b6f72000 r-xp /lib/libdl-2.13.so
b6f7b000 b6f87000 r-xp /usr/lib/libaul.so.0.1.0
b6f99000 b6f9e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa7000 b6fab000 r-xp /usr/lib/libsys-assert.so
b6fb4000 b6fd1000 r-xp /lib/ld-2.13.so
b6fda000 b6fdf000 r-xp /usr/bin/launchpad-loader
b7018000 b7200000 rw-p [heap]
bea8a000 beaab000 rwxp [stack]
bea8a000 beaab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:24496)
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
: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:52:52.339-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
06-12 18:52:52.339-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:52:52.339-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:52:52.359-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:52:52.589-0500 I/wnotib  ( 1166): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x40000
06-12 18:52:52.589-0500 I/wnotib  ( 1166): w-notification-board-broker-main.c: _wnotib_view_event_handler(1256) > On the cover view. Go to home.
06-12 18:52:52.589-0500 W/W_HOME  ( 1166): noti_broker.c: _noti_broker_back_cb(769) > continue the back key execution
06-12 18:52:52.589-0500 E/W_HOME  ( 1166): cs_broker.c: _cs_broker_back_cb(240) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-12 18:52:52.589-0500 W/W_HOME  ( 1166): main.c: _back_key_cb(1613) > emit:signal => key,back,clicked
06-12 18:52:52.589-0500 W/W_HOME  ( 1166): clock_event.c: _back_key_cb(278) > 
06-12 18:52:52.599-0500 W/WATCH_CORE(24453): appcore-watch.c: __widget_text_signal_cb(1028) > widget_text_signal
06-12 18:52:52.989-0500 I/CAPI_WATCH_APPLICATION(24453): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:52:53.179-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.179-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:52:53.179-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [true][0m
06-12 18:52:53.179-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:53.209-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:52:53.209-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:53.229-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1166
06-12 18:52:53.239-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.249-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:52:53.249-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:52:53.249-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.249-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:52:53.249-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:52:53.249-0500 I/TIZEN_N_SOUND_MANAGER( 1592): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-12 18:52:53.249-0500 W/TIZEN_N_SOUND_MANAGER( 1592): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:52:53.249-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:52:53.259-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:52:53.569-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: main(2131) > package manager server start
06-12 18:52:53.629-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_2019552206], req_type=[12], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[], cookie=[CBZC0IUyYb1vwIn3aebuxH8GSAM=], backend_flag=[0]
06-12 18:52:53.639-0500 E/PKGMGR_SERVER(24825): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.decimalwatch]
06-12 18:52:53.649-0500 E/PKGMGR  (24817): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.decimalwatch, -1]
06-12 18:52:53.719-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:53.719-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24453
06-12 18:52:53.719-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 18:52:53.729-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 18:52:53.729-0500 E/AUL_AMD (  926): amd_request.c: __app_process_by_pid(193) > pid(23876) is dead. cmd(5) is canceled
06-12 18:52:53.729-0500 E/PKGMGR_SERVER(24825): pkgmgr-server.c: __terminate_app(1393) > [0;31m[__terminate_app(): 1393](ret < 0) aul_terminate_pid[-3] fail
06-12 18:52:53.729-0500 E/PKGMGR_SERVER(24825): [0;m
06-12 18:52:53.729-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 18:52:53.729-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(24453), cmd(4)
06-12 18:52:53.729-0500 W/CAPI_WATCH_APPLICATION(24453): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
06-12 18:52:53.729-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 22
06-12 18:52:53.729-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(890) > app status : 4
06-12 18:52:53.729-0500 W/WATCH_CORE(24453): appcore-watch.c: __widget_destroy(992) > widget_destory
06-12 18:52:53.729-0500 E/WIDGET_PROVIDER_APP(24453): client.c: client_fini(1175) > Provider is not initialized
06-12 18:52:53.729-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 4
06-12 18:52:53.739-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:53.739-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24453
06-12 18:52:53.769-0500 E/AUL_AMD (  926): amd_launch.c: __reply_handler(898) > recv error : Connection reset by peer
06-12 18:52:53.769-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(24453), cmd(4)
06-12 18:52:53.769-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 0
06-12 18:52:53.779-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:52:53.789-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:52:53.789-0500 E/AUL_AMD (  926): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
06-12 18:52:53.789-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(1708) > caller pid : 1122
06-12 18:52:53.829-0500 E/RESOURCED(  928): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.decimalwatch, table num : 7
06-12 18:52:53.829-0500 E/RESOURCED(  928): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-12 18:52:53.829-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(2086) > pad pid(-5)
06-12 18:52:53.829-0500 W/AUL_PAD ( 1664): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
06-12 18:52:53.829-0500 W/AUL_PAD ( 1664): launchpad.c: __send_result_to_caller(272) > Check app launching
06-12 18:52:53.869-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: watch_app_main(382) > watch_app_main
06-12 18:52:53.939-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:53.949-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:53.949-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24453
06-12 18:52:53.949-0500 E/AUL     (  926): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-12 18:52:53.979-0500 W/WATCH_CORE(24496): appcore-watch.c: __widget_create(958) > widget_create
06-12 18:52:53.979-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1712) > [SECURE_LOG] [90170.304688] pkgname: org.example.decimalwatch, id: file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_90170.304688.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://18874524:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
06-12 18:52:53.979-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[90170.304688] pkgname[org.example.decimalwatch], id[file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_90170.304688.png] content[] cluster[user,created] category[default] widget_fname[pixmap://18874524:4] gbar_fname[]
06-12 18:52:53.989-0500 E/WIDGET_VIEWER( 1166): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
06-12 18:52:53.989-0500 E/WIDGET_EVAS( 1166): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
06-12 18:52:54.049-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.049-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.079-0500 W/WATCH_CORE(24496): appcore-watch.c: __widget_create(976) > widget_create done
06-12 18:52:54.149-0500 I/WATCH_CORE(24496): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
06-12 18:52:54.149-0500 I/WATCH_CORE(24496): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
06-12 18:52:54.149-0500 I/WATCH_CORE(24496): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
06-12 18:52:54.159-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.159-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.259-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.269-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.379-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.379-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.489-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.489-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.589-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.599-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.699-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.699-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.809-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.809-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.909-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.919-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.939-0500 W/AUL_AMD (  926): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-12 18:52:54.939-0500 W/AUL_AMD (  926): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
06-12 18:52:54.949-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:54.959-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:54.959-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 18:52:55.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.029-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.069-0500 E/EFL     (24837): elementary<24837> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 18:52:55.069-0500 E/EFL     (24837): elementary<24837> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 18:52:55.089-0500 E/EFL     (24837): elementary<24837> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 18:52:55.089-0500 E/EFL     (24837): elementary<24837> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 18:52:55.119-0500 E/EFL     (24837): elementary<24837> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 18:52:55.119-0500 E/EFL     (24837): elementary<24837> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 18:52:55.119-0500 E/EFL     (24837): elementary<24837> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 18:52:55.119-0500 E/EFL     (24837): elementary<24837> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 18:52:55.119-0500 E/EFL     (24837): elementary<24837> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 18:52:55.129-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.139-0500 E/EFL     (24837): elementary<24837> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 18:52:55.139-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.139-0500 E/EFL     (24837): elementary<24837> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 18:52:55.139-0500 E/EFL     (24837): elementary<24837> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 18:52:55.159-0500 E/EFL     (24837): elementary<24837> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 18:52:55.169-0500 E/EFL     (24837): elementary<24837> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 18:52:55.169-0500 E/EFL     (24837): elementary<24837> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 18:52:55.169-0500 E/EFL     (24837): elementary<24837> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 18:52:55.169-0500 E/EFL     (24837): elementary<24837> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 18:52:55.169-0500 E/EFL     (24837): elementary<24837> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 18:52:55.169-0500 E/EFL     (24837): elementary<24837> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 18:52:55.169-0500 I/AUL_PAD (24837): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 18:52:55.239-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.249-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.349-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.369-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.469-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.489-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.599-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.619-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.729-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.759-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.759-0500 W/AUL_AMD (  926): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
06-12 18:52:55.859-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:55.879-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:55.989-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.009-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.119-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.139-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.239-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.259-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.309-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:52:56.369-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.389-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.499-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.519-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.619-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.649-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.749-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.769-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.879-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:56.879-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:56.989-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.009-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.119-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.139-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.249-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.269-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.379-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.399-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.499-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.529-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.639-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.659-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.769-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.789-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:57.899-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:57.919-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.039-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.149-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.179-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.279-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.299-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.309-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:52:58.409-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.429-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.539-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.559-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.659-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.679-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.789-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.809-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:58.919-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:58.939-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.039-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.069-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.169-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.209-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.309-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.319-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.429-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.439-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.549-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.569-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.679-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.699-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.799-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:52:59.819-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24496
06-12 18:52:59.939-0500 E/PKGMGR_SERVER(24825): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
06-12 18:52:59.979-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: sighandler(409) > child NORMAL exit [24825]
06-12 18:53:00.309-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 18:53:00.309-0500 E/PKGMGR_SERVER(24823): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:53:02.069-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:53:05.419-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 18:53:05.469-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0xa9f239a8 -> 360 0 0xaea29388
06-12 18:53:05.469-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 18:53:05.479-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
06-12 18:53:05.479-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:53:05.479-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.479-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.479-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 18:53:05.499-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.499-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.509-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.509-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.529-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 18:53:05.529-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.529-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.549-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.549-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.559-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.559-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.579-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.579-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.589-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.589-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.609-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.609-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.629-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.629-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.649-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.649-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.659-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.659-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.669-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 18:53:05.669-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(2)
06-12 18:53:05.679-0500 W/WATCH_CORE(24496): appcore-watch.c: __widget_pause(1001) > widget_pause
06-12 18:53:05.739-0500 E/WATCH_CORE(24496): appcore-watch.c: __do_app(322) > Invalid state
06-12 18:53:05.809-0500 E/W_HOME  ( 1166): home_navigation.c: _vi_init(941) > (scroller_info->vi_info.on == 1) -> _vi_init() return
06-12 18:53:05.809-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0xaea29388 -> 360 0 0xaeaaaa60
06-12 18:53:05.829-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.829-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.839-0500 W/WATCH_CORE(24496): appcore-watch.c: __widget_resume(1012) > widget_resume
06-12 18:53:05.839-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:05.839-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.839-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.859-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.859-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.879-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.879-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.899-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.899-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.909-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.909-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.929-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.929-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.949-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.949-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.959-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
06-12 18:53:05.959-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:53:05.969-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.969-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.969-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 18:53:05.979-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.979-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:05.989-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:05.999-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:05.999-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:06.019-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 18:53:06.019-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 18:53:06.019-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 18:53:06.019-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(1)
06-12 18:53:06.159-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 18:53:06.519-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 18:53:06.989-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:07.989-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:08.999-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:09.989-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:10.989-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:11.999-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:12.509-0500 E/PKGMGR  (24931): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 18:53:12.649-0500 E/PKGMGR_SERVER(24933): pkgmgr-server.c: main(2131) > package manager server start
06-12 18:53:12.739-0500 E/PKGMGR_SERVER(24933): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_2038657069], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_2038657069' '-r' 'org.example.decimalwatch'], cookie=[33O8/VvNcNVD6kcU4DIzX8Eli4o=], backend_flag=[0]
06-12 18:53:12.749-0500 E/PKGMGR  (24933): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 18:53:12.749-0500 E/PKGMGR_SERVER(24933): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 18:53:12.749-0500 E/PKGMGR  (24931): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[249310002]
06-12 18:53:12.749-0500 E/PKGMGR_SERVER(24938): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 18:53:12.989-0500 I/CAPI_WATCH_APPLICATION(24496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:53:13.019-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 18:53:13.019-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 18:53:13.029-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 18:53:13.029-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:53:13.199-0500 W/CRASH_MANAGER(24941): worker.c: worker_job(1199) > 1124496646563146577559
