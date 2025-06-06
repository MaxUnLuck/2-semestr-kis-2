PGDMP                      }         	   TaxiMaxim    17.2    17.2 U    E           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            F           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            G           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            H           1262    66686 	   TaxiMaxim    DATABASE        CREATE DATABASE "TaxiMaxim" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.utf8';
    DROP DATABASE "TaxiMaxim";
                     postgres    false                        2615    66687 	   TaxiMaxim    SCHEMA        CREATE SCHEMA "TaxiMaxim";
    DROP SCHEMA "TaxiMaxim";
                     postgres    false            �            1259    66817    Customer    TABLE     -  CREATE TABLE "TaxiMaxim"."Customer" (
    pk_customer bigint NOT NULL,
    "phoneNumber" character(11) NOT NULL,
    email character varying(255) NOT NULL,
    first_name character varying(255) NOT NULL,
    midle_name character varying(255) NOT NULL,
    last_name character varying(255) NOT NULL
);
 #   DROP TABLE "TaxiMaxim"."Customer";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66816    Customer_pk_customer_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Customer_pk_customer_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE "TaxiMaxim"."Customer_pk_customer_seq";
    	   TaxiMaxim               postgres    false    6    230            I           0    0    Customer_pk_customer_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE "TaxiMaxim"."Customer_pk_customer_seq" OWNED BY "TaxiMaxim"."Customer".pk_customer;
       	   TaxiMaxim               postgres    false    229            �            1259    66806    Order    TABLE     �   CREATE TABLE "TaxiMaxim"."Order" (
    fk_customer bigint NOT NULL,
    fk_time bigint NOT NULL,
    fk_status smallint NOT NULL,
    fk_service bigint NOT NULL,
    fk_user bigint NOT NULL
);
     DROP TABLE "TaxiMaxim"."Order";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66801    Order_fk_customer_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Order_fk_customer_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE "TaxiMaxim"."Order_fk_customer_seq";
    	   TaxiMaxim               postgres    false    6    228            J           0    0    Order_fk_customer_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE "TaxiMaxim"."Order_fk_customer_seq" OWNED BY "TaxiMaxim"."Order".fk_customer;
       	   TaxiMaxim               postgres    false    223            �            1259    66804    Order_fk_service_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Order_fk_service_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE "TaxiMaxim"."Order_fk_service_seq";
    	   TaxiMaxim               postgres    false    6    228            K           0    0    Order_fk_service_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE "TaxiMaxim"."Order_fk_service_seq" OWNED BY "TaxiMaxim"."Order".fk_service;
       	   TaxiMaxim               postgres    false    226            �            1259    66803    Order_fk_status_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Order_fk_status_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE "TaxiMaxim"."Order_fk_status_seq";
    	   TaxiMaxim               postgres    false    228    6            L           0    0    Order_fk_status_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE "TaxiMaxim"."Order_fk_status_seq" OWNED BY "TaxiMaxim"."Order".fk_status;
       	   TaxiMaxim               postgres    false    225            �            1259    66802    Order_fk_time_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Order_fk_time_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE "TaxiMaxim"."Order_fk_time_seq";
    	   TaxiMaxim               postgres    false    228    6            M           0    0    Order_fk_time_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE "TaxiMaxim"."Order_fk_time_seq" OWNED BY "TaxiMaxim"."Order".fk_time;
       	   TaxiMaxim               postgres    false    224            �            1259    66805    Order_fk_user_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Order_fk_user_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE "TaxiMaxim"."Order_fk_user_seq";
    	   TaxiMaxim               postgres    false    6    228            N           0    0    Order_fk_user_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE "TaxiMaxim"."Order_fk_user_seq" OWNED BY "TaxiMaxim"."Order".fk_user;
       	   TaxiMaxim               postgres    false    227            �            1259    66784    Role    TABLE     1  CREATE TABLE "TaxiMaxim"."Role" (
    pk_role smallint NOT NULL,
    name character varying(20) NOT NULL,
    right_create_order boolean NOT NULL,
    right_edit_order boolean NOT NULL,
    right_view_order boolean NOT NULL,
    right_create_role boolean NOT NULL,
    right_edit_role boolean NOT NULL
);
    DROP TABLE "TaxiMaxim"."Role";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66783    Role_pk_role_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Role_pk_role_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE "TaxiMaxim"."Role_pk_role_seq";
    	   TaxiMaxim               postgres    false    219    6            O           0    0    Role_pk_role_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE "TaxiMaxim"."Role_pk_role_seq" OWNED BY "TaxiMaxim"."Role".pk_role;
       	   TaxiMaxim               postgres    false    218            �            1259    66841    Service    TABLE     �   CREATE TABLE "TaxiMaxim"."Service" (
    pk_service bigint NOT NULL,
    cargo boolean NOT NULL,
    passengers boolean NOT NULL,
    fk_user bigint NOT NULL
);
 "   DROP TABLE "TaxiMaxim"."Service";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66840    Service_fk_user_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Service_fk_user_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE "TaxiMaxim"."Service_fk_user_seq";
    	   TaxiMaxim               postgres    false    6    237            P           0    0    Service_fk_user_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE "TaxiMaxim"."Service_fk_user_seq" OWNED BY "TaxiMaxim"."Service".fk_user;
       	   TaxiMaxim               postgres    false    236            �            1259    66839    Service_pk_service_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Service_pk_service_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE "TaxiMaxim"."Service_pk_service_seq";
    	   TaxiMaxim               postgres    false    237    6            Q           0    0    Service_pk_service_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE "TaxiMaxim"."Service_pk_service_seq" OWNED BY "TaxiMaxim"."Service".pk_service;
       	   TaxiMaxim               postgres    false    235            �            1259    66833    Status    TABLE     p   CREATE TABLE "TaxiMaxim"."Status" (
    pk_status smallint NOT NULL,
    name character varying(15) NOT NULL
);
 !   DROP TABLE "TaxiMaxim"."Status";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66832    Status_pk_status_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Status_pk_status_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE "TaxiMaxim"."Status_pk_status_seq";
    	   TaxiMaxim               postgres    false    6    234            R           0    0    Status_pk_status_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE "TaxiMaxim"."Status_pk_status_seq" OWNED BY "TaxiMaxim"."Status".pk_status;
       	   TaxiMaxim               postgres    false    233            �            1259    66826    Time    TABLE     �   CREATE TABLE "TaxiMaxim"."Time" (
    pk_time bigint NOT NULL,
    registration_time time without time zone NOT NULL,
    start_time time without time zone NOT NULL,
    end_time time without time zone NOT NULL
);
    DROP TABLE "TaxiMaxim"."Time";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66825    Time_pk_time_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."Time_pk_time_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE "TaxiMaxim"."Time_pk_time_seq";
    	   TaxiMaxim               postgres    false    6    232            S           0    0    Time_pk_time_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE "TaxiMaxim"."Time_pk_time_seq" OWNED BY "TaxiMaxim"."Time".pk_time;
       	   TaxiMaxim               postgres    false    231            �            1259    66792    User    TABLE     H  CREATE TABLE "TaxiMaxim"."User" (
    pk_user bigint NOT NULL,
    email character varying(255) NOT NULL,
    password character varying(255) NOT NULL,
    first_name character varying(255) NOT NULL,
    midle_name character varying(255) NOT NULL,
    last_name character varying(255) NOT NULL,
    fk_role smallint NOT NULL
);
    DROP TABLE "TaxiMaxim"."User";
    	   TaxiMaxim         heap r       postgres    false    6            �            1259    66791    User_fk_role_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."User_fk_role_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE "TaxiMaxim"."User_fk_role_seq";
    	   TaxiMaxim               postgres    false    6    222            T           0    0    User_fk_role_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE "TaxiMaxim"."User_fk_role_seq" OWNED BY "TaxiMaxim"."User".fk_role;
       	   TaxiMaxim               postgres    false    221            �            1259    66790    User_pk_user_seq    SEQUENCE     �   CREATE SEQUENCE "TaxiMaxim"."User_pk_user_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE "TaxiMaxim"."User_pk_user_seq";
    	   TaxiMaxim               postgres    false    6    222            U           0    0    User_pk_user_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE "TaxiMaxim"."User_pk_user_seq" OWNED BY "TaxiMaxim"."User".pk_user;
       	   TaxiMaxim               postgres    false    220            �           2604    66820    Customer pk_customer    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Customer" ALTER COLUMN pk_customer SET DEFAULT nextval('"TaxiMaxim"."Customer_pk_customer_seq"'::regclass);
 J   ALTER TABLE "TaxiMaxim"."Customer" ALTER COLUMN pk_customer DROP DEFAULT;
    	   TaxiMaxim               postgres    false    229    230    230                       2604    66809    Order fk_customer    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Order" ALTER COLUMN fk_customer SET DEFAULT nextval('"TaxiMaxim"."Order_fk_customer_seq"'::regclass);
 G   ALTER TABLE "TaxiMaxim"."Order" ALTER COLUMN fk_customer DROP DEFAULT;
    	   TaxiMaxim               postgres    false    223    228    228            �           2604    66810    Order fk_time    DEFAULT     |   ALTER TABLE ONLY "TaxiMaxim"."Order" ALTER COLUMN fk_time SET DEFAULT nextval('"TaxiMaxim"."Order_fk_time_seq"'::regclass);
 C   ALTER TABLE "TaxiMaxim"."Order" ALTER COLUMN fk_time DROP DEFAULT;
    	   TaxiMaxim               postgres    false    228    224    228            �           2604    66811    Order fk_status    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Order" ALTER COLUMN fk_status SET DEFAULT nextval('"TaxiMaxim"."Order_fk_status_seq"'::regclass);
 E   ALTER TABLE "TaxiMaxim"."Order" ALTER COLUMN fk_status DROP DEFAULT;
    	   TaxiMaxim               postgres    false    225    228    228            �           2604    66812    Order fk_service    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Order" ALTER COLUMN fk_service SET DEFAULT nextval('"TaxiMaxim"."Order_fk_service_seq"'::regclass);
 F   ALTER TABLE "TaxiMaxim"."Order" ALTER COLUMN fk_service DROP DEFAULT;
    	   TaxiMaxim               postgres    false    226    228    228            �           2604    66813    Order fk_user    DEFAULT     |   ALTER TABLE ONLY "TaxiMaxim"."Order" ALTER COLUMN fk_user SET DEFAULT nextval('"TaxiMaxim"."Order_fk_user_seq"'::regclass);
 C   ALTER TABLE "TaxiMaxim"."Order" ALTER COLUMN fk_user DROP DEFAULT;
    	   TaxiMaxim               postgres    false    228    227    228            |           2604    66787    Role pk_role    DEFAULT     z   ALTER TABLE ONLY "TaxiMaxim"."Role" ALTER COLUMN pk_role SET DEFAULT nextval('"TaxiMaxim"."Role_pk_role_seq"'::regclass);
 B   ALTER TABLE "TaxiMaxim"."Role" ALTER COLUMN pk_role DROP DEFAULT;
    	   TaxiMaxim               postgres    false    219    218    219            �           2604    66844    Service pk_service    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Service" ALTER COLUMN pk_service SET DEFAULT nextval('"TaxiMaxim"."Service_pk_service_seq"'::regclass);
 H   ALTER TABLE "TaxiMaxim"."Service" ALTER COLUMN pk_service DROP DEFAULT;
    	   TaxiMaxim               postgres    false    237    235    237            �           2604    66845    Service fk_user    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Service" ALTER COLUMN fk_user SET DEFAULT nextval('"TaxiMaxim"."Service_fk_user_seq"'::regclass);
 E   ALTER TABLE "TaxiMaxim"."Service" ALTER COLUMN fk_user DROP DEFAULT;
    	   TaxiMaxim               postgres    false    237    236    237            �           2604    66836    Status pk_status    DEFAULT     �   ALTER TABLE ONLY "TaxiMaxim"."Status" ALTER COLUMN pk_status SET DEFAULT nextval('"TaxiMaxim"."Status_pk_status_seq"'::regclass);
 F   ALTER TABLE "TaxiMaxim"."Status" ALTER COLUMN pk_status DROP DEFAULT;
    	   TaxiMaxim               postgres    false    233    234    234            �           2604    66829    Time pk_time    DEFAULT     z   ALTER TABLE ONLY "TaxiMaxim"."Time" ALTER COLUMN pk_time SET DEFAULT nextval('"TaxiMaxim"."Time_pk_time_seq"'::regclass);
 B   ALTER TABLE "TaxiMaxim"."Time" ALTER COLUMN pk_time DROP DEFAULT;
    	   TaxiMaxim               postgres    false    232    231    232            }           2604    66795    User pk_user    DEFAULT     z   ALTER TABLE ONLY "TaxiMaxim"."User" ALTER COLUMN pk_user SET DEFAULT nextval('"TaxiMaxim"."User_pk_user_seq"'::regclass);
 B   ALTER TABLE "TaxiMaxim"."User" ALTER COLUMN pk_user DROP DEFAULT;
    	   TaxiMaxim               postgres    false    222    220    222            ~           2604    66796    User fk_role    DEFAULT     z   ALTER TABLE ONLY "TaxiMaxim"."User" ALTER COLUMN fk_role SET DEFAULT nextval('"TaxiMaxim"."User_fk_role_seq"'::regclass);
 B   ALTER TABLE "TaxiMaxim"."User" ALTER COLUMN fk_role DROP DEFAULT;
    	   TaxiMaxim               postgres    false    222    221    222            ;          0    66817    Customer 
   TABLE DATA           o   COPY "TaxiMaxim"."Customer" (pk_customer, "phoneNumber", email, first_name, midle_name, last_name) FROM stdin;
 	   TaxiMaxim               postgres    false    230   (g       9          0    66806    Order 
   TABLE DATA           \   COPY "TaxiMaxim"."Order" (fk_customer, fk_time, fk_status, fk_service, fk_user) FROM stdin;
 	   TaxiMaxim               postgres    false    228   Eg       0          0    66784    Role 
   TABLE DATA           �   COPY "TaxiMaxim"."Role" (pk_role, name, right_create_order, right_edit_order, right_view_order, right_create_role, right_edit_role) FROM stdin;
 	   TaxiMaxim               postgres    false    219   bg       B          0    66841    Service 
   TABLE DATA           P   COPY "TaxiMaxim"."Service" (pk_service, cargo, passengers, fk_user) FROM stdin;
 	   TaxiMaxim               postgres    false    237   �g       ?          0    66833    Status 
   TABLE DATA           8   COPY "TaxiMaxim"."Status" (pk_status, name) FROM stdin;
 	   TaxiMaxim               postgres    false    234   �g       =          0    66826    Time 
   TABLE DATA           W   COPY "TaxiMaxim"."Time" (pk_time, registration_time, start_time, end_time) FROM stdin;
 	   TaxiMaxim               postgres    false    232   Lh       3          0    66792    User 
   TABLE DATA           k   COPY "TaxiMaxim"."User" (pk_user, email, password, first_name, midle_name, last_name, fk_role) FROM stdin;
 	   TaxiMaxim               postgres    false    222   ih       V           0    0    Customer_pk_customer_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('"TaxiMaxim"."Customer_pk_customer_seq"', 1, false);
       	   TaxiMaxim               postgres    false    229            W           0    0    Order_fk_customer_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('"TaxiMaxim"."Order_fk_customer_seq"', 1, false);
       	   TaxiMaxim               postgres    false    223            X           0    0    Order_fk_service_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('"TaxiMaxim"."Order_fk_service_seq"', 1, false);
       	   TaxiMaxim               postgres    false    226            Y           0    0    Order_fk_status_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('"TaxiMaxim"."Order_fk_status_seq"', 1, false);
       	   TaxiMaxim               postgres    false    225            Z           0    0    Order_fk_time_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('"TaxiMaxim"."Order_fk_time_seq"', 1, false);
       	   TaxiMaxim               postgres    false    224            [           0    0    Order_fk_user_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('"TaxiMaxim"."Order_fk_user_seq"', 1, false);
       	   TaxiMaxim               postgres    false    227            \           0    0    Role_pk_role_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('"TaxiMaxim"."Role_pk_role_seq"', 4, true);
       	   TaxiMaxim               postgres    false    218            ]           0    0    Service_fk_user_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('"TaxiMaxim"."Service_fk_user_seq"', 1, false);
       	   TaxiMaxim               postgres    false    236            ^           0    0    Service_pk_service_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('"TaxiMaxim"."Service_pk_service_seq"', 1, false);
       	   TaxiMaxim               postgres    false    235            _           0    0    Status_pk_status_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('"TaxiMaxim"."Status_pk_status_seq"', 4, true);
       	   TaxiMaxim               postgres    false    233            `           0    0    Time_pk_time_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('"TaxiMaxim"."Time_pk_time_seq"', 1, false);
       	   TaxiMaxim               postgres    false    231            a           0    0    User_fk_role_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('"TaxiMaxim"."User_fk_role_seq"', 1, false);
       	   TaxiMaxim               postgres    false    221            b           0    0    User_pk_user_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('"TaxiMaxim"."User_pk_user_seq"', 4, true);
       	   TaxiMaxim               postgres    false    220            �           2606    66824    Customer Customer_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY "TaxiMaxim"."Customer"
    ADD CONSTRAINT "Customer_pkey" PRIMARY KEY (pk_customer);
 I   ALTER TABLE ONLY "TaxiMaxim"."Customer" DROP CONSTRAINT "Customer_pkey";
    	   TaxiMaxim                 postgres    false    230            �           2606    66815    Order Order_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Order"
    ADD CONSTRAINT "Order_pkey" PRIMARY KEY (fk_customer, fk_time, fk_status, fk_service, fk_user);
 C   ALTER TABLE ONLY "TaxiMaxim"."Order" DROP CONSTRAINT "Order_pkey";
    	   TaxiMaxim                 postgres    false    228    228    228    228    228            �           2606    66789    Role Role_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY "TaxiMaxim"."Role"
    ADD CONSTRAINT "Role_pkey" PRIMARY KEY (pk_role);
 A   ALTER TABLE ONLY "TaxiMaxim"."Role" DROP CONSTRAINT "Role_pkey";
    	   TaxiMaxim                 postgres    false    219            �           2606    66847    Service Service_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY "TaxiMaxim"."Service"
    ADD CONSTRAINT "Service_pkey" PRIMARY KEY (pk_service);
 G   ALTER TABLE ONLY "TaxiMaxim"."Service" DROP CONSTRAINT "Service_pkey";
    	   TaxiMaxim                 postgres    false    237            �           2606    66838    Status Status_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY "TaxiMaxim"."Status"
    ADD CONSTRAINT "Status_pkey" PRIMARY KEY (pk_status);
 E   ALTER TABLE ONLY "TaxiMaxim"."Status" DROP CONSTRAINT "Status_pkey";
    	   TaxiMaxim                 postgres    false    234            �           2606    66831    Time Time_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY "TaxiMaxim"."Time"
    ADD CONSTRAINT "Time_pkey" PRIMARY KEY (pk_time);
 A   ALTER TABLE ONLY "TaxiMaxim"."Time" DROP CONSTRAINT "Time_pkey";
    	   TaxiMaxim                 postgres    false    232            �           2606    66800    User User_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY "TaxiMaxim"."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY (pk_user);
 A   ALTER TABLE ONLY "TaxiMaxim"."User" DROP CONSTRAINT "User_pkey";
    	   TaxiMaxim                 postgres    false    222            �           2606    66853    Order Order_fk_customer_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Order"
    ADD CONSTRAINT "Order_fk_customer_fkey" FOREIGN KEY (fk_customer) REFERENCES "TaxiMaxim"."Customer"(pk_customer) NOT VALID;
 O   ALTER TABLE ONLY "TaxiMaxim"."Order" DROP CONSTRAINT "Order_fk_customer_fkey";
    	   TaxiMaxim               postgres    false    4752    228    230            �           2606    66868    Order Order_fk_service_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Order"
    ADD CONSTRAINT "Order_fk_service_fkey" FOREIGN KEY (fk_service) REFERENCES "TaxiMaxim"."Service"(pk_service) NOT VALID;
 N   ALTER TABLE ONLY "TaxiMaxim"."Order" DROP CONSTRAINT "Order_fk_service_fkey";
    	   TaxiMaxim               postgres    false    4758    228    237            �           2606    66863    Order Order_fk_status_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Order"
    ADD CONSTRAINT "Order_fk_status_fkey" FOREIGN KEY (fk_status) REFERENCES "TaxiMaxim"."Status"(pk_status) NOT VALID;
 M   ALTER TABLE ONLY "TaxiMaxim"."Order" DROP CONSTRAINT "Order_fk_status_fkey";
    	   TaxiMaxim               postgres    false    4756    234    228            �           2606    66858    Order Order_fk_time_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Order"
    ADD CONSTRAINT "Order_fk_time_fkey" FOREIGN KEY (fk_time) REFERENCES "TaxiMaxim"."Time"(pk_time) NOT VALID;
 K   ALTER TABLE ONLY "TaxiMaxim"."Order" DROP CONSTRAINT "Order_fk_time_fkey";
    	   TaxiMaxim               postgres    false    232    4754    228            �           2606    66873    Order Order_fk_user_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Order"
    ADD CONSTRAINT "Order_fk_user_fkey" FOREIGN KEY (fk_user) REFERENCES "TaxiMaxim"."User"(pk_user) NOT VALID;
 K   ALTER TABLE ONLY "TaxiMaxim"."Order" DROP CONSTRAINT "Order_fk_user_fkey";
    	   TaxiMaxim               postgres    false    222    228    4748            �           2606    66878    Service Service_fk_user_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."Service"
    ADD CONSTRAINT "Service_fk_user_fkey" FOREIGN KEY (fk_user) REFERENCES "TaxiMaxim"."User"(pk_user) NOT VALID;
 O   ALTER TABLE ONLY "TaxiMaxim"."Service" DROP CONSTRAINT "Service_fk_user_fkey";
    	   TaxiMaxim               postgres    false    222    4748    237            �           2606    66848    User User_fk_role_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY "TaxiMaxim"."User"
    ADD CONSTRAINT "User_fk_role_fkey" FOREIGN KEY (fk_role) REFERENCES "TaxiMaxim"."Role"(pk_role) NOT VALID;
 I   ALTER TABLE ONLY "TaxiMaxim"."User" DROP CONSTRAINT "User_fk_role_fkey";
    	   TaxiMaxim               postgres    false    219    4746    222            ;      x������ � �      9      x������ � �      0   f   x�EM�	�0;�7��gϝ��/S��ZWH72QB�!�Kj�Ǟ'\��w�����F�"��E���G~�V)���V>�8�;`�ǖ��W�zC�B�      B      x������ � �      ?   G   x�3估�.쾰������8/L��}a��}@��PAc�s/lU��	CƄ�¼�M����=... �@6�      =      x������ � �      3   \   x�M�K
�0�/�����Mi���E������c�57��/�O�t$���3M�ʨ6)�q����%��hT9_��5gAP0=_��     