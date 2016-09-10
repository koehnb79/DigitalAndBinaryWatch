S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 22644
Date: 2016-06-12 18:28:12-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8c0

Register Information
r0   = 0xbeea0300, r1   = 0xbeea01a0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbeea0568, r5   = 0xbeea0300
r6   = 0x00000132, r7   = 0xbeea02b0
r8   = 0xb6cdc9c0, r9   = 0xb7921140
r10  = 0xb6ceab18, fp   = 0x0000017e
ip   = 0xb5b92380, sp   = 0xbeea0160
lr   = 0xb5b89dcf, pc   = 0x000008c0
cpsr = 0xa0000010

Memory Information
MemTotal:   391348 KB
MemFree:     25860 KB
Buffers:      6460 KB
Cached:      76964 KB
VmPeak:      73256 KB
VmSize:      72712 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14360 KB
VmRSS:       14360 KB
VmData:      21332 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 22644 TID = 22644
22644 23083 23091 

Maps Information
b2c7a000 b3479000 rwxp [stack:23091]
b3514000 b352b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3538000 b35bf000 rw-s anon_inode:dmabuf
b35bf000 b35ca000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b35d3000 b35d5000 r-xp /usr/lib/libgenlock.so
b35e8000 b35eb000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b35f4000 b3df3000 rwxp [stack:23083]
b3ff3000 b3ffa000 r-xp /usr/lib/libtbm.so.1.0.0
b4002000 b4004000 r-xp /usr/lib/libdri2.so.0.0.0
b400c000 b4011000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4019000 b4021000 r-xp /usr/lib/libdrm.so.2.4.0
b4029000 b4032000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b403b000 b4047000 r-xp /usr/lib/libwidget_service.so.1.0.0
b404f000 b4058000 r-xp /usr/lib/libcom-core.so.0.0.1
b55e8000 b55ee000 r-xp /usr/lib/libwidget.so.1.0.0
b55f7000 b55fd000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b5605000 b56e9000 r-xp /usr/lib/libicuuc.so.51.1
b56fe000 b583b000 r-xp /usr/lib/libicui18n.so.51.1
b584b000 b5858000 r-xp /usr/lib/libalarm.so.0.0.0
b5861000 b5868000 r-xp /usr/lib/libappcore-watch.so.1.1
b5a10000 b5a1a000 r-xp /lib/libnss_files-2.13.so
b5a23000 b5af2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5b08000 b5b2c000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b35000 b5b3b000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b43000 b5b45000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b4e000 b5b52000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b64000 b5b69000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b71000 b5b73000 r-xp /usr/lib/libiniparser.so.0
b5b7c000 b5b81000 r-xp /usr/lib/libappcore-common.so.1.1
b5b89000 b5b8b000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5b93000 b5b97000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5ba4000 b5ba6000 r-xp /usr/lib/libXau.so.6.0.0
b5baf000 b5bb6000 r-xp /lib/libcrypt-2.13.so
b5be6000 b5be8000 r-xp /usr/lib/libiri.so
b5bf0000 b5d98000 r-xp /usr/lib/libcrypto.so.1.0.0
b5db1000 b5dfe000 r-xp /usr/lib/libssl.so.1.0.0
b5e0b000 b5e39000 r-xp /usr/lib/libidn.so.11.5.44
b5e41000 b5e4a000 r-xp /usr/lib/libcares.so.2.1.0
b5e53000 b5e66000 r-xp /usr/lib/libxcb.so.1.1.0
b5e6f000 b5e71000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e7a000 b5e7c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e85000 b5f51000 r-xp /usr/lib/libxml2.so.2.7.8
b5f5e000 b5f60000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f68000 b5f6d000 r-xp /usr/lib/libffi.so.5.0.10
b5f75000 b5f76000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f7f000 b5f8a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f92000 b5f95000 r-xp /lib/libattr.so.1.1.0
b5f9d000 b6031000 r-xp /usr/lib/libstdc++.so.6.0.16
b6044000 b6061000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b606a000 b6082000 r-xp /usr/lib/libpng12.so.0.50.0
b608b000 b60a1000 r-xp /lib/libexpat.so.1.5.2
b60ab000 b60ef000 r-xp /usr/lib/libcurl.so.4.3.0
b60f8000 b6102000 r-xp /usr/lib/libXext.so.6.4.0
b610b000 b610f000 r-xp /usr/lib/libXtst.so.6.1.0
b6117000 b611d000 r-xp /usr/lib/libXrender.so.1.3.0
b6126000 b612c000 r-xp /usr/lib/libXrandr.so.2.2.0
b6134000 b6135000 r-xp /usr/lib/libXinerama.so.1.0.0
b613e000 b6147000 r-xp /usr/lib/libXi.so.6.1.0
b614f000 b6152000 r-xp /usr/lib/libXfixes.so.3.1.0
b615a000 b615c000 r-xp /usr/lib/libXgesture.so.7.0.0
b6164000 b6166000 r-xp /usr/lib/libXcomposite.so.1.0.0
b616f000 b6171000 r-xp /usr/lib/libXdamage.so.1.1.0
b6179000 b6180000 r-xp /usr/lib/libXcursor.so.1.0.2
b6188000 b618b000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6193000 b6197000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61a0000 b61a5000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61af000 b6290000 r-xp /usr/lib/libX11.so.6.3.0
b629b000 b62be000 r-xp /usr/lib/libjpeg.so.8.0.2
b62d6000 b62ec000 r-xp /lib/libz.so.1.2.5
b62f4000 b6369000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6373000 b6389000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6392000 b63c6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63cf000 b64a2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64ad000 b64bd000 r-xp /lib/libresolv-2.13.so
b64c1000 b653d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6549000 b6561000 r-xp /usr/lib/liblzma.so.5.0.3
b656a000 b656d000 r-xp /lib/libcap.so.2.21
b6575000 b65a2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b65aa000 b65ab000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65b3000 b65b9000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65c1000 b65d8000 r-xp /usr/lib/liblua-5.1.so
b65e2000 b65e9000 r-xp /usr/lib/libembryo.so.1.7.99
b65f1000 b65f7000 r-xp /lib/librt-2.13.so
b6600000 b6656000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6663000 b66b9000 r-xp /usr/lib/libfreetype.so.6.11.3
b66c5000 b66ed000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66ef000 b672c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6735000 b6748000 r-xp /usr/lib/libfribidi.so.0.3.1
b6750000 b676a000 r-xp /usr/lib/libecore_con.so.1.7.99
b6773000 b677c000 r-xp /usr/lib/libedbus.so.1.7.99
b6784000 b67d4000 r-xp /usr/lib/libecore_x.so.1.7.99
b67d7000 b67db000 r-xp /usr/lib/libvconf.so.0.2.45
b67e3000 b67f4000 r-xp /usr/lib/libecore_input.so.1.7.99
b67fc000 b6801000 r-xp /usr/lib/libecore_file.so.1.7.99
b6809000 b682b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6834000 b6875000 r-xp /usr/lib/libeina.so.1.7.99
b687e000 b6897000 r-xp /usr/lib/libeet.so.1.7.99
b68a8000 b6911000 r-xp /lib/libm-2.13.so
b691a000 b6920000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6929000 b692c000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6934000 b6956000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b695e000 b6963000 r-xp /usr/lib/libxdgmime.so.1.1.0
b696b000 b6995000 r-xp /usr/lib/libdbus-1.so.3.8.12
b699e000 b69b5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69bd000 b69c8000 r-xp /lib/libunwind.so.8.0.1
b69f5000 b6a31000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a3a000 b6b55000 r-xp /lib/libc-2.13.so
b6b63000 b6b6b000 r-xp /lib/libgcc_s-4.6.so.1
b6b6c000 b6b6f000 r-xp /usr/lib/libsmack.so.1.0.0
b6b77000 b6b7d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b85000 b6c55000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c56000 b6cb3000 r-xp /usr/lib/libedje.so.1.7.99
b6cbd000 b6cd4000 r-xp /usr/lib/libecore.so.1.7.99
b6ceb000 b6db9000 r-xp /usr/lib/libevas.so.1.7.99
b6dde000 b6f19000 r-xp /usr/lib/libelementary.so.1.7.99
b6f2f000 b6f43000 r-xp /lib/libpthread-2.13.so
b6f4e000 b6f50000 r-xp /usr/lib/libdlog.so.0.0.0
b6f58000 b6f5b000 r-xp /usr/lib/libbundle.so.0.1.22
b6f63000 b6f65000 r-xp /lib/libdl-2.13.so
b6f6e000 b6f7a000 r-xp /usr/lib/libaul.so.0.1.0
b6f8c000 b6f91000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f9a000 b6f9e000 r-xp /usr/lib/libsys-assert.so
b6fa7000 b6fc4000 r-xp /lib/ld-2.13.so
b6fcd000 b6fd2000 r-xp /usr/bin/launchpad-loader
b78e8000 b7aaf000 rw-p [heap]
bee80000 beea1000 rwxp [stack]
bee80000 beea1000 rwxp [stack]
End of Maps Information

Callstack Information (PID:22644)
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
API_WATCH_APPLICATION(22496): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:27:54.999-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.009-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.009-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 18:27:55.009-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 18:27:55.009-0500 E/AUL_AMD (  926): amd_request.c: __app_process_by_pid(193) > pid(13963) is dead. cmd(5) is canceled
06-12 18:27:55.009-0500 E/PKGMGR_SERVER(23057): pkgmgr-server.c: __terminate_app(1393) > [0;31m[__terminate_app(): 1393](ret < 0) aul_terminate_pid[-3] fail
06-12 18:27:55.009-0500 E/PKGMGR_SERVER(23057): [0;m
06-12 18:27:55.009-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 5
06-12 18:27:55.019-0500 W/CAPI_WATCH_APPLICATION(22496): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
06-12 18:27:55.019-0500 W/WATCH_CORE(22496): appcore-watch.c: __widget_destroy(992) > widget_destory
06-12 18:27:55.019-0500 E/WIDGET_PROVIDER_APP(22496): client.c: client_fini(1175) > Provider is not initialized
06-12 18:27:55.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 22
06-12 18:27:55.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(890) > app status : 4
06-12 18:27:55.019-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(22496), cmd(4)
06-12 18:27:55.019-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.029-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.029-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 4
06-12 18:27:55.129-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.149-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.249-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.279-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.379-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.399-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.509-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.529-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.639-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.659-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.759-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.789-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:55.899-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:55.919-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.029-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.059-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.159-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.179-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.289-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.309-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.419-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.449-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.549-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.589-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.689-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.699-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.809-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.829-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:56.939-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:56.959-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22496
06-12 18:27:57.059-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:57.079-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:27:57.089-0500 E/PKGMGR_SERVER(23057): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
06-12 18:27:57.129-0500 E/AUL_AMD (  926): amd_launch.c: __reply_handler(898) > recv error : Connection reset by peer
06-12 18:27:57.129-0500 W/AUL_AMD (  926): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(22496), cmd(4)
06-12 18:27:57.129-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 0
06-12 18:27:57.139-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:27:57.149-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:27:57.149-0500 E/AUL_AMD (  926): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
06-12 18:27:57.149-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(1708) > caller pid : 1122
06-12 18:27:57.179-0500 W/W_HOME  ( 1166): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-12 18:27:57.179-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:27:57.179-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_enable(133) > 1
06-12 18:27:57.179-0500 W/W_HOME  ( 1166): event_manager.c: _lcd_off_cb(699) > lcd state: 0
06-12 18:27:57.179-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:57.179-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
06-12 18:27:57.179-0500 W/STARTER ( 1103): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
06-12 18:27:57.179-0500 E/STARTER ( 1103): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
06-12 18:27:57.179-0500 W/STARTER ( 1103): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
06-12 18:27:57.179-0500 W/STARTER ( 1103): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
06-12 18:27:57.189-0500 E/PKGMGR_SERVER(23052): pkgmgr-server.c: sighandler(409) > child NORMAL exit [23057]
06-12 18:27:57.199-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(963) > [0;32mINFO: LCDOff receive data : -1226765556[0;m
06-12 18:27:57.199-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(964) > [0;32mINFO: WakeupServiceStop[0;m
06-12 18:27:57.199-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStop(401) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-12 18:27:57.199-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
06-12 18:27:57.209-0500 E/RESOURCED(  928): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.decimalwatch, table num : 7
06-12 18:27:57.209-0500 E/RESOURCED(  928): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-12 18:27:57.259-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-12 18:27:57.259-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-12 18:27:57.259-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 0[0;m
06-12 18:27:57.259-0500 I/HIGEAR  ( 1551): WakeupService.cpp: WakeupServiceStop(405) > [svoice:Application:WakeupServiceStop:IN]
06-12 18:27:57.299-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(2086) > pad pid(-5)
06-12 18:27:57.299-0500 W/AUL_PAD ( 1664): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
06-12 18:27:57.299-0500 W/AUL_PAD ( 1664): launchpad.c: __send_result_to_caller(272) > Check app launching
06-12 18:27:57.309-0500 E/PKGMGR_SERVER(23052): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 18:27:57.309-0500 E/PKGMGR_SERVER(23052): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 18:27:57.329-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: watch_app_main(382) > watch_app_main
06-12 18:27:57.409-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 23
06-12 18:27:57.409-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:27:57.409-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 13963
06-12 18:27:57.409-0500 W/AUL_AMD (  926): amd_request.c: __send_app_termination_signal(511) > send dead signal done
06-12 18:27:57.409-0500 E/AUL     (23070): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-12 18:27:57.419-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13963
06-12 18:27:57.439-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
06-12 18:27:57.439-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
06-12 18:27:57.439-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
06-12 18:27:57.439-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
06-12 18:27:57.439-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: PAUSE State: RUNNING
06-12 18:27:57.439-0500 I/CAPI_APPFW_APPLICATION( 1166): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 18:27:57.439-0500 W/W_HOME  ( 1166): main.c: _appcore_pause_cb(692) > appcore pause
06-12 18:27:57.439-0500 W/W_HOME  ( 1166): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
06-12 18:27:57.439-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:57.439-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:57.439-0500 W/W_HOME  ( 1166): main.c: home_pause(762) > clock/widget paused
06-12 18:27:57.439-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:27:57.449-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:27:57.449-0500 E/AUL     (  926): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-12 18:27:57.449-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 18:27:57.449-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
06-12 18:27:57.449-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:27:57.449-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
06-12 18:27:57.449-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:27:57.449-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [false][0m
06-12 18:27:57.449-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:57.459-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:27:57.529-0500 W/WATCH_CORE(22644): appcore-watch.c: __widget_create(958) > widget_create
06-12 18:27:57.529-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1712) > [SECURE_LOG] [80620.210938] pkgname: org.example.decimalwatch, id: file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_80620.210938.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://18874496:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
06-12 18:27:57.529-0500 E/WIDGET_VIEWER( 1166): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[80620.210938] pkgname[org.example.decimalwatch], id[file:///opt/usr/share/live_magazine/org.example.decimalwatch_1166_80620.210938.png] content[] cluster[user,created] category[default] widget_fname[pixmap://18874496:4] gbar_fname[]
06-12 18:27:57.549-0500 E/WIDGET_VIEWER( 1166): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
06-12 18:27:57.549-0500 E/WIDGET_EVAS( 1166): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
06-12 18:27:57.609-0500 W/WATCH_CORE(22644): appcore-watch.c: __widget_create(976) > widget_create done
06-12 18:27:57.669-0500 I/WATCH_CORE(22644): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
06-12 18:27:57.669-0500 I/WATCH_CORE(22644): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
06-12 18:27:57.669-0500 I/WATCH_CORE(22644): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
06-12 18:27:57.709-0500 W/WATCH_CORE(22644): appcore-watch.c: __widget_resume(1012) > widget_resume
06-12 18:27:57.739-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:27:57.739-0500 W/WATCH_CORE(22644): appcore-watch.c: __widget_pause(1001) > widget_pause
06-12 18:27:57.949-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: MEM_FLUSH State: PAUSED
06-12 18:27:58.409-0500 W/AUL_AMD (  926): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-12 18:27:58.409-0500 W/AUL_AMD (  926): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
06-12 18:27:58.429-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:58.439-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22644
06-12 18:27:58.439-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 18:27:58.549-0500 E/EFL     (23092): elementary<23092> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 18:27:58.549-0500 E/EFL     (23092): elementary<23092> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 18:27:58.559-0500 E/EFL     (23092): elementary<23092> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 18:27:58.569-0500 E/EFL     (23092): elementary<23092> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 18:27:58.589-0500 E/EFL     (23092): elementary<23092> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 18:27:58.589-0500 E/EFL     (23092): elementary<23092> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 18:27:58.589-0500 E/EFL     (23092): elementary<23092> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 18:27:58.589-0500 E/EFL     (23092): elementary<23092> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 18:27:58.589-0500 E/EFL     (23092): elementary<23092> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 18:27:58.609-0500 E/EFL     (23092): elementary<23092> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 18:27:58.619-0500 E/EFL     (23092): elementary<23092> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 18:27:58.619-0500 E/EFL     (23092): elementary<23092> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 18:27:58.639-0500 E/EFL     (23092): elementary<23092> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 18:27:58.649-0500 E/EFL     (23092): elementary<23092> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 18:27:58.649-0500 E/EFL     (23092): elementary<23092> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 18:27:58.649-0500 E/EFL     (23092): elementary<23092> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 18:27:58.649-0500 E/EFL     (23092): elementary<23092> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 18:27:58.649-0500 E/EFL     (23092): elementary<23092> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 18:27:58.649-0500 E/EFL     (23092): elementary<23092> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 18:27:58.649-0500 I/AUL_PAD (23092): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 18:27:58.899-0500 W/WATCH_CORE(22644): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
06-12 18:27:58.899-0500 I/WATCH_CORE(22644): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
06-12 18:27:58.899-0500 W/wnotibp (13988): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
06-12 18:27:58.919-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(954) > [0;32mINFO: LCDOn receive data : -1226765556[0;m
06-12 18:27:58.919-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(955) > [0;32mINFO: WakeupServiceStart[0;m
06-12 18:27:58.919-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStart(371) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-12 18:27:58.919-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_set(161) > timer set
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): gesture.c: _apps_status_get(123) > apps status:0
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:1857
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_schedule(211) > schedule, manual render
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): event_manager.c: _lcd_on_cb(691) > lcd state: 1
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:58.919-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [powerkey] after screen off time [1857]ms
06-12 18:27:58.919-0500 W/STARTER ( 1103): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:27:58.919-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: RESUME State: PAUSED
06-12 18:27:58.919-0500 I/CAPI_APPFW_APPLICATION( 1166): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): main.c: _appcore_resume_cb(683) > appcore resume
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): main.c: home_resume(735) > clock/widget resumed
06-12 18:27:58.919-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:27:58.919-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 18:27:58.919-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-12 18:27:58.919-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStart(390) > [0;32mINFO: 500[0;m
06-12 18:27:58.919-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
06-12 18:27:58.929-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-12 18:27:58.929-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
06-12 18:27:58.929-0500 W/WATCH_CORE(22644): appcore-watch.c: __widget_resume(1012) > widget_resume
06-12 18:27:58.929-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:27:58.939-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-12 18:27:58.939-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-12 18:27:58.939-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 1[0;m
06-12 18:27:58.939-0500 I/HIGEAR  ( 1551): WakeupService.cpp: WakeupServiceStart(395) > [svoice:Application:WakeupServiceStart:IN]
06-12 18:27:58.939-0500 W/W_HOME  ( 1166): gesture.c: _widget_updated_cb(190) > widget updated
06-12 18:27:58.939-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:27:58.939-0500 W/W_HOME  ( 1166): gesture.c: _manual_render(176) > 
06-12 18:27:58.979-0500 W/W_HOME  ( 1166): gesture.c: _manual_render(176) > 
06-12 18:27:58.989-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:27:58.999-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_enable(133) > 0
06-12 18:27:59.009-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
06-12 18:27:59.039-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [powerkey]
06-12 18:27:59.039-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:27:59.119-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
06-12 18:27:59.119-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:27:59.129-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:27:59.919-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:27:59.929-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:27:59.929-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:27:59.929-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [true][0m
06-12 18:27:59.939-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:59.959-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:27:59.959-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:27:59.979-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1166
06-12 18:27:59.989-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:27:59.989-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:27:59.989-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:27:59.989-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:27:59.989-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:27:59.999-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:28:00.009-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:28:00.019-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:28:00.019-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:28:00.019-0500 I/TIZEN_N_SOUND_MANAGER( 1592): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-12 18:28:00.019-0500 W/TIZEN_N_SOUND_MANAGER( 1592): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:28:00.019-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:28:00.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:28:01.859-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:28:01.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:02.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:03.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:04.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:05.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:06.989-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:07.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:08.999-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:09.989-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:10.989-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:11.599-0500 E/PKGMGR  (23174): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 18:28:11.739-0500 E/PKGMGR_SERVER(23176): pkgmgr-server.c: main(2131) > package manager server start
06-12 18:28:11.809-0500 E/PKGMGR_SERVER(23176): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_537743769], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_537743769' '-r' 'org.example.decimalwatch'], cookie=[ka3Mi88gYS1tnJ0+oa1ZL4l32ns=], backend_flag=[0]
06-12 18:28:11.809-0500 E/PKGMGR  (23176): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 18:28:11.809-0500 E/PKGMGR_SERVER(23176): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 18:28:11.809-0500 E/PKGMGR_SERVER(23181): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 18:28:11.829-0500 E/PKGMGR  (23174): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[231740002]
06-12 18:28:11.969-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 18:28:11.969-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 18:28:11.979-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 18:28:11.989-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:28:11.989-0500 I/CAPI_WATCH_APPLICATION(22644): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 18:28:12.109-0500 W/CERT_SVC(23181): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
06-12 18:28:12.159-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:28:12.169-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-12 18:28:12.179-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 131
06-12 18:28:12.179-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 131
06-12 18:28:12.179-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 54 1
06-12 18:28:12.179-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 55 1
06-12 18:28:12.179-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 56 1
06-12 18:28:12.179-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 57 1
06-12 18:28:12.189-0500 E/PKGMGR_CERT(23181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-12 18:28:12.249-0500 W/CRASH_MANAGER(23183): worker.c: worker_job(1199) > 1122644646563146577409
