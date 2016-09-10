S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 12387
Date: 2016-06-12 11:57:49-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1a6

Register Information
r0   = 0x0000019a, r1   = 0x0000000d
r2   = 0x0000000a, r3   = 0xb5b38194
r4   = 0x0000019a, r5   = 0x00000000
r6   = 0xb7d7f58c, r7   = 0xb7d71008
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6f7adc0
ip   = 0xbef54c7c, sp   = 0xbef54c30
lr   = 0xb6f600d0, pc   = 0xb6f5f9dc
cpsr = 0x20000010

Memory Information
MemTotal:   391348 KB
MemFree:     20636 KB
Buffers:      5236 KB
Cached:      71824 KB
VmPeak:      72928 KB
VmSize:      72384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14108 KB
VmRSS:       14108 KB
VmData:      21004 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 12387 TID = 12387
12387 12550 12558 

Maps Information
b2c29000 b3428000 rwxp [stack:12558]
b34c3000 b34da000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b34e7000 b356e000 rw-s anon_inode:dmabuf
b356e000 b3579000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3582000 b3584000 r-xp /usr/lib/libgenlock.so
b3597000 b359a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b35a3000 b3da2000 rwxp [stack:12550]
b3fa2000 b3fa9000 r-xp /usr/lib/libtbm.so.1.0.0
b3fb1000 b3fb3000 r-xp /usr/lib/libdri2.so.0.0.0
b3fbb000 b3fc0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fc8000 b3fd0000 r-xp /usr/lib/libdrm.so.2.4.0
b3fd8000 b3fe1000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3fea000 b3ff6000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3ffe000 b4007000 r-xp /usr/lib/libcom-core.so.0.0.1
b5597000 b559d000 r-xp /usr/lib/libwidget.so.1.0.0
b55a6000 b55ac000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b55b4000 b5698000 r-xp /usr/lib/libicuuc.so.51.1
b56ad000 b57ea000 r-xp /usr/lib/libicui18n.so.51.1
b57fa000 b5807000 r-xp /usr/lib/libalarm.so.0.0.0
b5810000 b5817000 r-xp /usr/lib/libappcore-watch.so.1.1
b59bf000 b59c9000 r-xp /lib/libnss_files-2.13.so
b59d2000 b5aa1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5ab7000 b5adb000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ae4000 b5aea000 r-xp /usr/lib/libappsvc.so.0.1.0
b5af2000 b5af4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5afd000 b5b01000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b13000 b5b18000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b20000 b5b22000 r-xp /usr/lib/libiniparser.so.0
b5b2b000 b5b30000 r-xp /usr/lib/libappcore-common.so.1.1
b5b38000 b5b3a000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5b42000 b5b46000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b53000 b5b55000 r-xp /usr/lib/libXau.so.6.0.0
b5b5e000 b5b65000 r-xp /lib/libcrypt-2.13.so
b5b95000 b5b97000 r-xp /usr/lib/libiri.so
b5b9f000 b5d47000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d60000 b5dad000 r-xp /usr/lib/libssl.so.1.0.0
b5dba000 b5de8000 r-xp /usr/lib/libidn.so.11.5.44
b5df0000 b5df9000 r-xp /usr/lib/libcares.so.2.1.0
b5e02000 b5e15000 r-xp /usr/lib/libxcb.so.1.1.0
b5e1e000 b5e20000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e29000 b5e2b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e34000 b5f00000 r-xp /usr/lib/libxml2.so.2.7.8
b5f0d000 b5f0f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f17000 b5f1c000 r-xp /usr/lib/libffi.so.5.0.10
b5f24000 b5f25000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f2e000 b5f39000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f41000 b5f44000 r-xp /lib/libattr.so.1.1.0
b5f4c000 b5fe0000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ff3000 b6010000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6019000 b6031000 r-xp /usr/lib/libpng12.so.0.50.0
b603a000 b6050000 r-xp /lib/libexpat.so.1.5.2
b605a000 b609e000 r-xp /usr/lib/libcurl.so.4.3.0
b60a7000 b60b1000 r-xp /usr/lib/libXext.so.6.4.0
b60ba000 b60be000 r-xp /usr/lib/libXtst.so.6.1.0
b60c6000 b60cc000 r-xp /usr/lib/libXrender.so.1.3.0
b60d5000 b60db000 r-xp /usr/lib/libXrandr.so.2.2.0
b60e3000 b60e4000 r-xp /usr/lib/libXinerama.so.1.0.0
b60ed000 b60f6000 r-xp /usr/lib/libXi.so.6.1.0
b60fe000 b6101000 r-xp /usr/lib/libXfixes.so.3.1.0
b6109000 b610b000 r-xp /usr/lib/libXgesture.so.7.0.0
b6113000 b6115000 r-xp /usr/lib/libXcomposite.so.1.0.0
b611e000 b6120000 r-xp /usr/lib/libXdamage.so.1.1.0
b6128000 b612f000 r-xp /usr/lib/libXcursor.so.1.0.2
b6137000 b613a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6142000 b6146000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b614f000 b6154000 r-xp /usr/lib/libecore_fb.so.1.7.99
b615e000 b623f000 r-xp /usr/lib/libX11.so.6.3.0
b624a000 b626d000 r-xp /usr/lib/libjpeg.so.8.0.2
b6285000 b629b000 r-xp /lib/libz.so.1.2.5
b62a3000 b6318000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6322000 b6338000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6341000 b6375000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b637e000 b6451000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b645c000 b646c000 r-xp /lib/libresolv-2.13.so
b6470000 b64ec000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64f8000 b6510000 r-xp /usr/lib/liblzma.so.5.0.3
b6519000 b651c000 r-xp /lib/libcap.so.2.21
b6524000 b6551000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6559000 b655a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6562000 b6568000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6570000 b6587000 r-xp /usr/lib/liblua-5.1.so
b6591000 b6598000 r-xp /usr/lib/libembryo.so.1.7.99
b65a0000 b65a6000 r-xp /lib/librt-2.13.so
b65af000 b6605000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6612000 b6668000 r-xp /usr/lib/libfreetype.so.6.11.3
b6674000 b669c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b669e000 b66db000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66e4000 b66f7000 r-xp /usr/lib/libfribidi.so.0.3.1
b66ff000 b6719000 r-xp /usr/lib/libecore_con.so.1.7.99
b6722000 b672b000 r-xp /usr/lib/libedbus.so.1.7.99
b6733000 b6783000 r-xp /usr/lib/libecore_x.so.1.7.99
b6786000 b678a000 r-xp /usr/lib/libvconf.so.0.2.45
b6792000 b67a3000 r-xp /usr/lib/libecore_input.so.1.7.99
b67ab000 b67b0000 r-xp /usr/lib/libecore_file.so.1.7.99
b67b8000 b67da000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67e3000 b6824000 r-xp /usr/lib/libeina.so.1.7.99
b682d000 b6846000 r-xp /usr/lib/libeet.so.1.7.99
b6857000 b68c0000 r-xp /lib/libm-2.13.so
b68c9000 b68cf000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68d8000 b68db000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68e3000 b6905000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b690d000 b6912000 r-xp /usr/lib/libxdgmime.so.1.1.0
b691a000 b6944000 r-xp /usr/lib/libdbus-1.so.3.8.12
b694d000 b6964000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b696c000 b6977000 r-xp /lib/libunwind.so.8.0.1
b69a4000 b69e0000 r-xp /usr/lib/libsystemd.so.0.4.0
b69e9000 b6b04000 r-xp /lib/libc-2.13.so
b6b12000 b6b1a000 r-xp /lib/libgcc_s-4.6.so.1
b6b1b000 b6b1e000 r-xp /usr/lib/libsmack.so.1.0.0
b6b26000 b6b2c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b34000 b6c04000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c05000 b6c62000 r-xp /usr/lib/libedje.so.1.7.99
b6c6c000 b6c83000 r-xp /usr/lib/libecore.so.1.7.99
b6c9a000 b6d68000 r-xp /usr/lib/libevas.so.1.7.99
b6d8d000 b6ec8000 r-xp /usr/lib/libelementary.so.1.7.99
b6ede000 b6ef2000 r-xp /lib/libpthread-2.13.so
b6efd000 b6eff000 r-xp /usr/lib/libdlog.so.0.0.0
b6f07000 b6f0a000 r-xp /usr/lib/libbundle.so.0.1.22
b6f12000 b6f14000 r-xp /lib/libdl-2.13.so
b6f1d000 b6f29000 r-xp /usr/lib/libaul.so.0.1.0
b6f3b000 b6f40000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f49000 b6f4d000 r-xp /usr/lib/libsys-assert.so
b6f56000 b6f73000 r-xp /lib/ld-2.13.so
b6f7c000 b6f81000 r-xp /usr/bin/launchpad-loader
b7c7f000 b7df4000 rw-p [heap]
bef35000 bef56000 rwxp [stack]
bef35000 bef56000 rwxp [stack]
End of Maps Information

Callstack Information (PID:12387)
Call Stack Count: 6
 0: (0xb6f5f9dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6f600d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6f60360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6f645e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6f6aa60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb6a5670c) [/lib/libc.so.6] + 0x6d70c
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
nd_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.202-0500 W/WATCH_CORE(12387): appcore-watch.c: __widget_create(976) > widget_create done
06-12 11:57:29.282-0500 I/WATCH_CORE(12387): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
06-12 11:57:29.282-0500 I/WATCH_CORE(12387): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
06-12 11:57:29.282-0500 I/WATCH_CORE(12387): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
06-12 11:57:29.302-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.312-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.422-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.422-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.522-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.532-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.642-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.642-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.742-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.752-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.852-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.852-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:29.952-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:29.962-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.072-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.072-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.092-0500 W/AUL_AMD (  926): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-12 11:57:30.092-0500 W/AUL_AMD (  926): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
06-12 11:57:30.102-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.112-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.112-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 12
06-12 11:57:30.172-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.182-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.232-0500 E/EFL     (12563): elementary<12563> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 11:57:30.232-0500 E/EFL     (12563): elementary<12563> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 11:57:30.252-0500 E/EFL     (12563): elementary<12563> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 11:57:30.252-0500 E/EFL     (12563): elementary<12563> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 11:57:30.282-0500 E/EFL     (12563): elementary<12563> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 11:57:30.282-0500 E/EFL     (12563): elementary<12563> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 11:57:30.282-0500 E/EFL     (12563): elementary<12563> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 11:57:30.282-0500 E/EFL     (12563): elementary<12563> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 11:57:30.282-0500 E/EFL     (12563): elementary<12563> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 11:57:30.282-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.292-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.302-0500 E/EFL     (12563): elementary<12563> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 11:57:30.302-0500 E/EFL     (12563): elementary<12563> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 11:57:30.302-0500 E/EFL     (12563): elementary<12563> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 11:57:30.342-0500 E/EFL     (12563): elementary<12563> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 11:57:30.352-0500 E/EFL     (12563): elementary<12563> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 11:57:30.352-0500 E/EFL     (12563): elementary<12563> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 11:57:30.352-0500 E/EFL     (12563): elementary<12563> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 11:57:30.352-0500 E/EFL     (12563): elementary<12563> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 11:57:30.352-0500 E/EFL     (12563): elementary<12563> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 11:57:30.352-0500 E/EFL     (12563): elementary<12563> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 11:57:30.352-0500 I/AUL_PAD (12563): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 11:57:30.392-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.402-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.502-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.512-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.612-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.632-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.742-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.752-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.852-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:30.882-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:30.942-0500 W/AUL_AMD (  926): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
06-12 11:57:30.982-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.012-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.122-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.142-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.252-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.272-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.382-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.392-0500 E/PKGMGR_SERVER(12547): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:57:31.402-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.512-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.532-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.632-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.662-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.772-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.792-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:31.892-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:31.922-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.022-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.052-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.152-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.172-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.282-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.302-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.412-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.432-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.522-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:57:32.532-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.562-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.672-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.682-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.792-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.812-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:32.912-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:32.942-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.052-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.072-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.072-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-12 11:57:33.172-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.202-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.312-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.322-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.382-0500 E/PKGMGR_SERVER(12547): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:57:33.422-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.452-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.552-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.582-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.682-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.712-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.812-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.842-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:33.942-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:33.962-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.072-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.082-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.192-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.202-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.312-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.332-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.432-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.462-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.562-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.582-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.682-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.692-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.802-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.822-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:34.932-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:57:34.952-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12387
06-12 11:57:35.072-0500 E/PKGMGR_SERVER(12548): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
06-12 11:57:35.102-0500 E/PKGMGR_SERVER(12547): pkgmgr-server.c: sighandler(409) > child NORMAL exit [12548]
06-12 11:57:35.382-0500 E/PKGMGR_SERVER(12547): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 11:57:35.382-0500 E/PKGMGR_SERVER(12547): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 11:57:37.302-0500 E/GESTURE (  260): gesture.c: GestureHandleButtonPressEvent(3375) > root_y=35   flick_area=45 ---> SET value to 1
06-12 11:57:37.302-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
06-12 11:57:37.302-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:57:37.302-0500 E/GESTURE (  260): gesture.c: GestureHandleButtonPressEvent(3375) > root_y=35   flick_area=45 ---> SET value to 1
06-12 11:57:37.312-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1091) > [_ecore_event_client_message_cb:1091] quickpanel 1
06-12 11:57:37.342-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:1
06-12 11:57:37.342-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:57:37.352-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_show(1377) > [windicator_moment_bar_show:1377] Show Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:57:37.352-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:57:37.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(301) > [_windi_sim_state_set:301] service_type(1) spn_disp_cond(0)
06-12 11:57:37.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(378) > [_windi_sim_state_set:378] text : (No service)
06-12 11:57:37.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_localized_txt_get(236) > [_windi_sim_state_localized_txt_get:236] 
06-12 11:57:37.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_localized_txt_get(274) > [_windi_sim_state_localized_txt_get:274] is_mapped : 1
06-12 11:57:37.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(382) > [_windi_sim_state_set:382] localize text : No service
06-12 11:57:37.352-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: _windi_sim_state_set(403) > [_windi_sim_state_set:403] plmn : (No service)
06-12 11:57:37.362-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 8/5, (0xb1346cc8)
06-12 11:57:37.362-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(878) > [_rssi_icon_set:878] Set RSSI SHOW sw.icon_0 (rssi_level : 8) (rssi_hide : 1)(b1346cc8)
06-12 11:57:37.362-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_verizon_No_signal
06-12 11:57:37.372-0500 E/GESTURE (  260): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
06-12 11:57:37.392-0500 E/EFL     (  605): <605> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
06-12 11:57:37.402-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
06-12 11:57:37.402-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 9/5, (0xb1346cc8)
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(873) > [_rssi_icon_set:873] Set RSSI HIDE sw.icon_0 (rssi_level : 9) (rssi_hide : 0)
06-12 11:57:37.412-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_none
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(866) > [_rssi_icon_set:866] RSSI level : 9/5, (0xb7cf0b48)
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(873) > [_rssi_icon_set:873] Set RSSI HIDE sw.icon_0 (rssi_level : 9) (rssi_hide : 1)
06-12 11:57:37.412-0500 I/W_INDICATOR( 1114): windicator_connection.c: _rssi_icon_set(884) > [_rssi_icon_set:884] Verizon or USCC / set_rssi_none
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_sim_state.c: windi_sim_state_remove(599) > [windi_sim_state_remove:599] 
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_type_changed_cb(1052) > [_connection_type_changed_cb:1052] wifi state : 2
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_type_changed_cb(1054) > [_connection_type_changed_cb:1054] 
06-12 11:57:37.412-0500 I/W_INDICATOR( 1114): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 10 / signal : type_wifi_connected_01
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 10) / (hide : 0)
06-12 11:57:37.412-0500 I/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(607) > [_connection_icon_set:607] 3G option : (1)
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(620) > [_connection_icon_set:620] EMERGENCY CB : (0)
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(628) > [_connection_icon_set:628] Dnet off :: Dim signal : type_wifi_connected_01 / 3G option on,off: (1)
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:57:37.412-0500 I/W_INDICATOR( 1114): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 10 / signal : type_wifi_connected_01
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 10) / (hide : 0)
06-12 11:57:37.412-0500 I/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(607) > [_connection_icon_set:607] 3G option : (1)
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(620) > [_connection_icon_set:620] EMERGENCY CB : (0)
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _connection_icon_set(628) > [_connection_icon_set:628] Dnet off :: Dim signal : type_wifi_connected_01 / 3G option on,off: (1)
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(767) > [_dynamic_bluetooth_state_changed_cb:767] isBTOn : 0
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(773) > [_dynamic_bluetooth_state_changed_cb:773] sap connected : 1
06-12 11:57:37.412-0500 W/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(779) > [_dynamic_bluetooth_state_changed_cb:779] sap connectivity type : 16
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(302) > [dynamic_event_icon_refresh_position_for_3g:302] rssi 1 connection 0
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: _dynamic_event_icon_del(238) > [_dynamic_event_icon_del:238] (item == NULL) -> _dynamic_event_icon_del() return
06-12 11:57:37.412-0500 E/W_INDICATOR( 1114): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(412) > [dynamic_event_icon_refresh_position_for_3g:412] rssi 1 connection 0
06-12 11:57:37.422-0500 I/W_INDICATOR( 1114): windicator_brightness.c: _current_device_brightness_level_get(142) > [_current_device_brightness_level_get:142] Brightness level : 80
06-12 11:57:37.422-0500 E/W_INDICATOR( 1114): windicator_volume.c: _current_device_volume_level_get(220) > [_current_device_volume_level_get:220] Failed to get volume by sound manager (return value : -1)
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_call_fwd_btn.c: windicator_call_fwd_btn_update(258) > [windicator_call_fwd_btn_update:258] 
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
06-12 11:57:37.422-0500 I/W_INDICATOR( 1114): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(95) > [windicator_scs_update:95] svc type : 1
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
06-12 11:57:37.422-0500 W/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 2
06-12 11:57:37.422-0500 I/W_INDICATOR( 1114): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
06-12 11:57:37.432-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1113) > [_ecore_event_client_message_cb:1113] quickpanel 0
06-12 11:57:37.432-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(960) > [_ecore_event_client_message_cb:960] quickpanel is closed
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:57:37.432-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:57:37.442-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:57:37.442-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 11:57:37.442-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.windicator]register msg port [false][0m
06-12 11:57:37.442-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _mp_messageport_register(324) > [_mp_messageport_register:324] Used message-port
06-12 11:57:37.442-0500 E/MESSAGE_PORT( 1114): message_port.cpp: message_port_unregister_local_port(123) > [MESSAGE_PORT_ERROR_PORT_NOT_FOUND] The local port ID (7) is not registered.
06-12 11:57:37.442-0500 E/W_INDICATOR( 1114): windicator_message_port.c: windicator_message_port_fini(354) > [windicator_message_port_fini:354] Failed to unregister music service message port cb
06-12 11:57:37.442-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_hide(1531) > [windicator_moment_bar_hide:1531] Hide Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:57:37.442-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb132d4e0, elm_layout, _activated_obj : 0x0, activated : 0
06-12 11:57:37.442-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 11:57:37.442-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb132d4e0, elm_layout, func : 0xb6eeb729
06-12 11:57:37.442-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 11:57:42.302-0500 E/PKGMGR  (12647): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 11:57:42.452-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: main(2131) > package manager server start
06-12 11:57:42.552-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_-1416713775], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_-1416713775' '-r' 'org.example.decimalwatch'], cookie=[6/7br30QrDPDnfDkd0ZDb1eyySk=], backend_flag=[0]
06-12 11:57:42.552-0500 E/PKGMGR  (12649): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 11:57:42.552-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 11:57:42.552-0500 E/PKGMGR_SERVER(12654): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 11:57:42.562-0500 E/PKGMGR  (12647): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[126470002]
06-12 11:57:42.702-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 11:57:42.712-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 11:57:42.722-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 11:57:42.722-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:57:42.842-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:57:42.862-0500 W/CERT_SVC(12654): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
06-12 11:57:42.922-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-12 11:57:42.922-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 131
06-12 11:57:42.922-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 131
06-12 11:57:42.922-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 54 1
06-12 11:57:42.922-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 55 1
06-12 11:57:42.932-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 56 1
06-12 11:57:42.932-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 57 1
06-12 11:57:42.932-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:57:42.952-0500 E/PKGMGR_CERT(12654): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-12 11:57:43.142-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 12373
06-12 11:57:43.222-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 12563
06-12 11:57:43.412-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-12 11:57:43.422-0500 E/EFL     (12656): elementary<12656> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 11:57:43.422-0500 E/EFL     (12656): elementary<12656> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 11:57:43.442-0500 E/EFL     (12656): elementary<12656> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 11:57:43.442-0500 E/EFL     (12656): elementary<12656> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 11:57:43.472-0500 E/EFL     (12656): elementary<12656> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 11:57:43.472-0500 E/EFL     (12656): elementary<12656> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 11:57:43.472-0500 E/EFL     (12656): elementary<12656> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 11:57:43.472-0500 E/EFL     (12656): elementary<12656> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 11:57:43.472-0500 E/EFL     (12656): elementary<12656> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 11:57:43.492-0500 E/EFL     (12656): elementary<12656> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 11:57:43.502-0500 E/EFL     (12656): elementary<12656> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 11:57:43.502-0500 E/EFL     (12656): elementary<12656> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 11:57:43.532-0500 E/EFL     (12656): elementary<12656> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 11:57:43.532-0500 E/EFL     (12656): elementary<12656> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 11:57:43.542-0500 E/EFL     (12656): elementary<12656> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 11:57:43.542-0500 E/EFL     (12656): elementary<12656> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 11:57:43.542-0500 E/EFL     (12656): elementary<12656> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 11:57:43.542-0500 E/EFL     (12656): elementary<12656> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 11:57:43.542-0500 E/EFL     (12656): elementary<12656> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 11:57:43.542-0500 I/AUL_PAD (12656): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 11:57:43.652-0500 I/efl-extension(12657): efl_extension.c: eext_mod_init(40) > Init
06-12 11:57:43.672-0500 E/EFL     (12657): elementary<12657> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 11:57:43.672-0500 E/EFL     (12657): elementary<12657> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 11:57:43.692-0500 E/EFL     (12657): elementary<12657> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 11:57:43.692-0500 I/UXT     (12657): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
06-12 11:57:43.692-0500 E/EFL     (12657): elementary<12657> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 11:57:43.722-0500 E/EFL     (12657): elementary<12657> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 11:57:43.722-0500 E/EFL     (12657): elementary<12657> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 11:57:43.722-0500 E/EFL     (12657): elementary<12657> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 11:57:43.722-0500 E/EFL     (12657): elementary<12657> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 11:57:43.722-0500 E/EFL     (12657): elementary<12657> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 11:57:43.742-0500 E/EFL     (12657): elementary<12657> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 11:57:43.742-0500 E/EFL     (12657): elementary<12657> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 11:57:43.742-0500 E/EFL     (12657): elementary<12657> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 11:57:43.772-0500 E/EFL     (12657): elementary<12657> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 11:57:43.782-0500 E/EFL     (12657): elementary<12657> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 11:57:43.782-0500 E/EFL     (12657): elementary<12657> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 11:57:43.782-0500 E/EFL     (12657): elementary<12657> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 11:57:43.782-0500 E/EFL     (12657): elementary<12657> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 11:57:43.782-0500 E/EFL     (12657): elementary<12657> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 11:57:43.782-0500 E/EFL     (12657): elementary<12657> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 11:57:43.782-0500 I/AUL_PAD (12657): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): OpenGL ES Shader Compiler Version: E031.24.00.16
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): Build Date: 09/02/15 Wed
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): Local Branch: 
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): Remote Branch: 
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): Local Patches: 
06-12 11:57:43.802-0500 I/Adreno-EGL(12657): Reconstruct Branch: 
06-12 11:57:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-12 11:57:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-12 11:57:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-12 11:57:44.192-0500 E/TIZEN_N_SYSTEM_SETTINGS( 1273): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-12 11:57:44.382-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:57:45.252-0500 E/rpm-installer(12654): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
06-12 11:57:46.382-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:57:48.382-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:57:48.532-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:57:48.582-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0xae1b7650 -> 360 0 0xaea29388
06-12 11:57:48.582-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 11:57:48.582-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
06-12 11:57:48.582-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:57:48.582-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.582-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.592-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 11:57:48.602-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.602-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.632-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 11:57:48.642-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.642-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.662-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
06-12 11:57:48.662-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:57:48.662-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.662-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.672-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 11:57:48.672-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.672-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.692-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.692-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.712-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.712-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.722-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.722-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.742-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:57:48.742-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:57:48.772-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 11:57:48.892-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 11:57:49.212-0500 E/PKGMGR_SERVER(12649): pkgmgr-server.c: sighandler(409) > child NORMAL exit [12654]
06-12 11:57:49.242-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:57:49.242-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, COMPLETED]
06-12 11:57:49.242-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6915) > package install complete
06-12 11:57:49.242-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_package_install_event(4787) > 
06-12 11:57:49.242-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
06-12 11:57:49.292-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.decimalwatch is updated, need to check validation
06-12 11:57:49.292-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.example.decimalwatch
06-12 11:57:49.312-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:57:49.312-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(249) > clock org.example.decimalwatch is updated, preload:0 update:0 event->update:0
06-12 11:57:49.312-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 11:57:49.382-0500 E/STARTER ( 1103): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
06-12 11:57:49.382-0500 E/APPS    ( 1166): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
06-12 11:57:49.392-0500 E/PKGMGR_INFO(  891): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-12 11:57:49.602-0500 W/CRASH_MANAGER(12661): worker.c: worker_job(1199) > 1112387646563146575066
