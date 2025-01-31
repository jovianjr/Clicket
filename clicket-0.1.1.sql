PGDMP         3            
    z            clicket    14.5    14.5 9    M           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            N           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            O           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            P           1262    16960    clicket    DATABASE     g   CREATE DATABASE clicket WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_Indonesia.1252';
    DROP DATABASE clicket;
                postgres    false            c           1247    17130    agerate    TYPE     Z   CREATE TYPE public.agerate AS ENUM (
    'G',
    'PG',
    'PG-13',
    'R',
    'NR'
);
    DROP TYPE public.agerate;
       public          postgres    false            Z           1247    17105    orderstatus    TYPE     T   CREATE TYPE public.orderstatus AS ENUM (
    'paid',
    'unpaid',
    'process'
);
    DROP TYPE public.orderstatus;
       public          postgres    false            �            1255    17252 %   confirm_order_event(integer, integer)    FUNCTION     l  CREATE FUNCTION public.confirm_order_event(_option integer, _id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
   IF _option = 1 THEN
      UPDATE "Event_Order" SET status = 'paid' WHERE id = _id;
   ELSE
      UPDATE "Event_Order" SET status = 'unpaid' WHERE id = _id;
   END IF;
   
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 H   DROP FUNCTION public.confirm_order_event(_option integer, _id integer);
       public          postgres    false            �            1255    17251 %   confirm_order_movie(integer, integer)    FUNCTION     l  CREATE FUNCTION public.confirm_order_movie(_option integer, _id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
   IF _option = 1 THEN
      UPDATE "Movie_Order" SET status = 'paid' WHERE id = _id;
   ELSE
      UPDATE "Movie_Order" SET status = 'unpaid' WHERE id = _id;
   END IF;
   
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 H   DROP FUNCTION public.confirm_order_movie(_option integer, _id integer);
       public          postgres    false            �            1255    17283    delete_event(integer)    FUNCTION     �   CREATE FUNCTION public.delete_event(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM "Event" WHERE id = _id;
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 0   DROP FUNCTION public.delete_event(_id integer);
       public          postgres    false            �            1255    17282    delete_movie(integer)    FUNCTION     �   CREATE FUNCTION public.delete_movie(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM "Movie" WHERE id = _id;
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 0   DROP FUNCTION public.delete_movie(_id integer);
       public          postgres    false            �            1255    17217    get_events()    FUNCTION     �  CREATE FUNCTION public.get_events() RETURNS TABLE(_id integer, _title character varying, _description character varying, _location character varying, _start_date timestamp without time zone, _end_date timestamp without time zone, _quota integer, _price integer, _image character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
	return query
	select id, title, description, location, start_date, end_date, quota, price, image from "Event";
end
$$;
 #   DROP FUNCTION public.get_events();
       public          postgres    false            �            1255    17174    get_movies()    FUNCTION     �  CREATE FUNCTION public.get_movies() RETURNS TABLE(_id integer, _title character varying, _description character varying, _location character varying, _date date, _duration_hour integer, _duration_min integer, _price integer, _quota integer, _image character varying, _genre character varying[], _agerate public.agerate)
    LANGUAGE plpgsql
    AS $$
BEGIN
	return query
	select id, title, description, location, date, duration_hour, duration_min, price, quota, image, genre, agerate from "Movie";
end
$$;
 #   DROP FUNCTION public.get_movies();
       public          postgres    false    867            �            1255    17264    get_order_history(integer)    FUNCTION     �  CREATE FUNCTION public.get_order_history(_id integer) RETURNS TABLE(_user_id integer, _username character varying, _type text, _status text, _title character varying, _date text, _location character varying, _price integer, _quantity integer, _total integer, _created_at timestamp without time zone)
    LANGUAGE plpgsql
    AS $$
BEGIN
    return query
    select 
        usr.id as user_id,
        usr.username,
        'event' as type, 
        CAST(status AS text),
        e.title,
        TO_CHAR(e.start_date, 'dd Month YYYY') || ' - ' || TO_CHAR(e.end_date, 'dd Month YYYY') as date, 
        e.location, 
        amount as price, 
        eo.quantity, 
        amount * eo.quantity as total,
		eo.created_at
    from 
        "Event_Order" eo, 
        "Event" as e,
        "User" as usr
    where eo.event_id = e.id
      and eo.user_id = usr.id
      and eo.user_id = _id
    UNION ALL
    select
        usr.id as user_id,
        usr.username,
        'movie' as type, 
        CAST(status AS text),
        movie.title, 
        TO_CHAR(movie.date, 'dd Month YYYY'), 
        movie.location, 
        amount as price, 
        mo.quantity, 
        amount * mo.quantity as total,
		mo.created_at
    from 
        "Movie_Order" mo, 
        "Movie" as movie,
        "User" as usr
    where mo.movie_id = movie.id
      and mo.user_id = usr.id
      and mo.user_id = _id
 order by created_at desc; 
end
$$;
 5   DROP FUNCTION public.get_order_history(_id integer);
       public          postgres    false            �            1255    17284    get_order_history_admin()    FUNCTION       CREATE FUNCTION public.get_order_history_admin() RETURNS TABLE(_id integer, _user_id integer, _username character varying, _type text, _status text, _title character varying, _date text, _location character varying, _price integer, _quantity integer, _total integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    return query
    select 
		eo.id,
        usr.id as user_id,
        usr.username,
        'event' as type, 
        CAST(status AS text),
        e.title,
        TO_CHAR(e.start_date, 'dd Month YYYY') || ' - ' || TO_CHAR(e.end_date, 'dd Month YYYY') as date, 
        e.location, 
        amount as price, 
        eo.quantity, 
        amount * eo.quantity as total 
    from 
        "Event_Order" eo, 
        "Event" as e,
        "User" as usr
    where eo.event_id = e.id
      and eo.user_id = usr.id
    UNION ALL
    select
		mo.id,
        usr.id as user_id,
        usr.username,
        'movie' as type, 
        CAST(status AS text),
        movie.title, 
        TO_CHAR(movie.date, 'dd Month YYYY'), 
        movie.location, 
        amount as price, 
        mo.quantity, 
        amount * mo.quantity as total 
    from 
        "Movie_Order" mo, 
        "Movie" as movie,
        "User" as usr
    where mo.movie_id = movie.id
      and mo.user_id = usr.id; 
end
$$;
 0   DROP FUNCTION public.get_order_history_admin();
       public          postgres    false            �            1255    17281 p   insert_event(text, text, text, timestamp without time zone, timestamp without time zone, integer, integer, text)    FUNCTION       CREATE FUNCTION public.insert_event(_title text, _description text, _location text, _start_date timestamp without time zone, _end_date timestamp without time zone, _price integer, _quota integer, _image text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO "Event"(
		title, description, location, start_date, end_date, price, quota, image
	)  
	VALUES(
		_title,_description,_location,_start_date,_end_date,_price,_quota,_image
	);
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 �   DROP FUNCTION public.insert_event(_title text, _description text, _location text, _start_date timestamp without time zone, _end_date timestamp without time zone, _price integer, _quota integer, _image text);
       public          postgres    false            �            1255    17276 s   insert_movie(text, text, text, timestamp without time zone, integer, integer, integer, integer, text, text[], text)    FUNCTION     q  CREATE FUNCTION public.insert_movie(_title text, _description text, _location text, _date timestamp without time zone, _duration_hour integer, _duration_min integer, _price integer, _quota integer, _image text, _genre text[], _agerate text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO "Movie"(
		title, description, location, date, duration_hour, duration_min, price, quota, image, genre, agerate
	)  
	VALUES(
		_title,_description,_location,_date,_duration_hour,_duration_min,_price,_quota,_image,_genre,CAST(_agerate AS agerate)
	);
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 �   DROP FUNCTION public.insert_movie(_title text, _description text, _location text, _date timestamp without time zone, _duration_hour integer, _duration_min integer, _price integer, _quota integer, _image text, _genre text[], _agerate text);
       public          postgres    false            �            1255    17265 +   login(character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.login(_uname character varying, _pw character varying) RETURNS TABLE(_id integer, _username character varying, _password character varying, _name character varying, _email character varying, _phone integer, _birth date, _role_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    return query
	select id, username, password, name, email, phone, birth, role_id from "User" where username = _uname and password = _pw;
end
$$;
 M   DROP FUNCTION public.login(_uname character varying, _pw character varying);
       public          postgres    false            �            1255    17262 B   order_event(integer, integer, integer, integer, character varying)    FUNCTION     �  CREATE FUNCTION public.order_event(_event_id integer, _user_id integer, _quantity integer, _amount integer, _file character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO "Event_Order"(
        event_id,
        user_id,
        quantity,
        amount,
		file
    )
    values
    (
        _event_id,
        _user_id,
        _quantity,
        _amount,
		_file
    );
    if found then return 1;
    else return 0;
    end if;
END
$$;
 �   DROP FUNCTION public.order_event(_event_id integer, _user_id integer, _quantity integer, _amount integer, _file character varying);
       public          postgres    false            �            1255    17261 B   order_movie(integer, integer, integer, integer, character varying)    FUNCTION     �  CREATE FUNCTION public.order_movie(_movie_id integer, _user_id integer, _quantity integer, _amount integer, _file character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO "Movie_Order"(
        movie_id,
        user_id,
        quantity,
        amount,
		file
    )
    values
    (
        _movie_id,
        _user_id,
        _quantity,
        _amount,
		_file
    );
    if found then return 1;
    else return 0;
    end if;
END
$$;
 �   DROP FUNCTION public.order_movie(_movie_id integer, _user_id integer, _quantity integer, _amount integer, _file character varying);
       public          postgres    false            �            1255    17286 E   sign_up(text, text, text, text, integer, timestamp without time zone)    FUNCTION     �  CREATE FUNCTION public.sign_up(_username text, _password text, _name text, _email text, _phone integer, _birth timestamp without time zone) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
   INSERT INTO "User" (username, password, name, email, phone, birth)
   VALUES (_username, _password, _name, _email, _phone, _birth);
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 �   DROP FUNCTION public.sign_up(_username text, _password text, _name text, _email text, _phone integer, _birth timestamp without time zone);
       public          postgres    false            �            1255    17273 y   update_event(integer, text, text, text, timestamp without time zone, timestamp without time zone, integer, integer, text)    FUNCTION     *  CREATE FUNCTION public.update_event(_id integer, _title text, _description text, _location text, _start_date timestamp without time zone, _end_date timestamp without time zone, _price integer, _quota integer, _image text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	UPDATE "Event" SET
	title = _title, 
	description = _description, 
	location = _location, 
	start_date = _start_date, 
	end_date = _end_date, 
	price = _price, 
	quota = _quota, 
	image = _image
   WHERE id = _id;
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 �   DROP FUNCTION public.update_event(_id integer, _title text, _description text, _location text, _start_date timestamp without time zone, _end_date timestamp without time zone, _price integer, _quota integer, _image text);
       public          postgres    false            �            1255    17272 |   update_movie(integer, text, text, text, timestamp without time zone, integer, integer, integer, integer, text, text[], text)    FUNCTION     �  CREATE FUNCTION public.update_movie(_id integer, _title text, _description text, _location text, _date timestamp without time zone, _duration_hour integer, _duration_min integer, _price integer, _quota integer, _image text, _genre text[], _agerate text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	UPDATE "Movie" SET
	title = _title, 
	description = _description, 
	location = _location, 
	date = _date, 
	duration_hour = _duration_hour, 
	duration_min = _duration_min, 
	price = _price, 
	quota = _quota, 
	image = _image, 
	genre = _genre, 
	agerate = CAST(_agerate AS agerate)
   WHERE id = _id;
   IF FOUND THEN return 1;
   ELSE return 0;
   END IF;
END
$$;
 �   DROP FUNCTION public.update_movie(_id integer, _title text, _description text, _location text, _date timestamp without time zone, _duration_hour integer, _duration_min integer, _price integer, _quota integer, _image text, _genre text[], _agerate text);
       public          postgres    false            �            1259    17001    Event    TABLE       CREATE TABLE public."Event" (
    id integer NOT NULL,
    title character varying(255) NOT NULL,
    description character varying(1000) NOT NULL,
    location character varying(100) NOT NULL,
    price integer NOT NULL,
    image character varying(255) NOT NULL,
    created_at timestamp without time zone DEFAULT now() NOT NULL,
    updated_at timestamp without time zone DEFAULT now() NOT NULL,
    start_date timestamp without time zone NOT NULL,
    end_date timestamp without time zone NOT NULL,
    quota integer DEFAULT 0 NOT NULL
);
    DROP TABLE public."Event";
       public         heap    postgres    false            �            1259    17008    Order_Event_id_seq    SEQUENCE     �   CREATE SEQUENCE public."Order_Event_id_seq"
    START WITH 1000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."Order_Event_id_seq";
       public          postgres    false            �            1259    17111    Event_Order    TABLE     "  CREATE TABLE public."Event_Order" (
    id integer DEFAULT nextval('public."Order_Event_id_seq"'::regclass) NOT NULL,
    event_id integer NOT NULL,
    user_id integer NOT NULL,
    status public.orderstatus DEFAULT 'process'::public.orderstatus NOT NULL,
    created_at timestamp without time zone DEFAULT now() NOT NULL,
    updated_at timestamp without time zone DEFAULT now() NOT NULL,
    quantity integer DEFAULT 0 NOT NULL,
    amount integer DEFAULT 0 NOT NULL,
    file character varying(1000) DEFAULT ''::character varying NOT NULL
);
 !   DROP TABLE public."Event_Order";
       public         heap    postgres    false    210    858    858            �            1259    17141    Movie    TABLE     ^  CREATE TABLE public."Movie" (
    id integer NOT NULL,
    title character varying(255) NOT NULL,
    description character varying(1000) NOT NULL,
    location character varying(100) NOT NULL,
    date date NOT NULL,
    duration_hour integer NOT NULL,
    duration_min integer NOT NULL,
    price integer NOT NULL,
    quota integer NOT NULL,
    image character varying(255) NOT NULL,
    genre character varying(255)[] NOT NULL,
    agerate public.agerate NOT NULL,
    created_at timestamp without time zone DEFAULT now() NOT NULL,
    updated_at timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public."Movie";
       public         heap    postgres    false    867            �            1259    17122    Order_Movie_id_seq    SEQUENCE     �   CREATE SEQUENCE public."Order_Movie_id_seq"
    START WITH 1000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."Order_Movie_id_seq";
       public          postgres    false            �            1259    17123    Movie_Order    TABLE     "  CREATE TABLE public."Movie_Order" (
    id integer DEFAULT nextval('public."Order_Movie_id_seq"'::regclass) NOT NULL,
    movie_id integer NOT NULL,
    user_id integer NOT NULL,
    status public.orderstatus DEFAULT 'process'::public.orderstatus NOT NULL,
    created_at timestamp without time zone DEFAULT now() NOT NULL,
    updated_at timestamp without time zone DEFAULT now() NOT NULL,
    quantity integer DEFAULT 0 NOT NULL,
    amount integer DEFAULT 0 NOT NULL,
    file character varying(1000) DEFAULT ''::character varying NOT NULL
);
 !   DROP TABLE public."Movie_Order";
       public         heap    postgres    false    216    858    858            �            1259    17037    Role_id_seq    SEQUENCE     y   CREATE SEQUENCE public."Role_id_seq"
    START WITH 1000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public."Role_id_seq";
       public          postgres    false            �            1259    17038    Role    TABLE       CREATE TABLE public."Role" (
    id integer DEFAULT nextval('public."Role_id_seq"'::regclass) NOT NULL,
    name character varying(255) NOT NULL,
    created_at timestamp without time zone DEFAULT now() NOT NULL,
    updated_at timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public."Role";
       public         heap    postgres    false    211            �            1259    17044    User_id_seq    SEQUENCE     y   CREATE SEQUENCE public."User_id_seq"
    START WITH 1000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public."User_id_seq";
       public          postgres    false            �            1259    17045    User    TABLE     �  CREATE TABLE public."User" (
    id integer DEFAULT nextval('public."User_id_seq"'::regclass) NOT NULL,
    role_id integer DEFAULT 1000 NOT NULL,
    username character varying(255) NOT NULL,
    password character varying(255) NOT NULL,
    name character varying(255) NOT NULL,
    email character varying(255) NOT NULL,
    phone integer,
    birth date,
    created_at timestamp without time zone DEFAULT now() NOT NULL,
    updated_at timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public."User";
       public         heap    postgres    false    213            �            1259    17175    event_id_seq    SEQUENCE     x   CREATE SEQUENCE public.event_id_seq
    START WITH 5000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.event_id_seq;
       public          postgres    false    209            Q           0    0    event_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.event_id_seq OWNED BY public."Event".id;
          public          postgres    false    220            �            1259    17158    movie_id_seq    SEQUENCE     x   CREATE SEQUENCE public.movie_id_seq
    START WITH 1000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.movie_id_seq;
       public          postgres    false    218            R           0    0    movie_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.movie_id_seq OWNED BY public."Movie".id;
          public          postgres    false    219            �           2604    17176    Event id    DEFAULT     f   ALTER TABLE ONLY public."Event" ALTER COLUMN id SET DEFAULT nextval('public.event_id_seq'::regclass);
 9   ALTER TABLE public."Event" ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    220    209            �           2604    17159    Movie id    DEFAULT     f   ALTER TABLE ONLY public."Movie" ALTER COLUMN id SET DEFAULT nextval('public.movie_id_seq'::regclass);
 9   ALTER TABLE public."Movie" ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    218            ?          0    17001    Event 
   TABLE DATA                 public          postgres    false    209   %f       E          0    17111    Event_Order 
   TABLE DATA                 public          postgres    false    215   �g       H          0    17141    Movie 
   TABLE DATA                 public          postgres    false    218   i       G          0    17123    Movie_Order 
   TABLE DATA                 public          postgres    false    217   �j       B          0    17038    Role 
   TABLE DATA                 public          postgres    false    212   Tl       D          0    17045    User 
   TABLE DATA                 public          postgres    false    214   �l       S           0    0    Order_Event_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Order_Event_id_seq"', 1003, true);
          public          postgres    false    210            T           0    0    Order_Movie_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Order_Movie_id_seq"', 1008, true);
          public          postgres    false    216            U           0    0    Role_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."Role_id_seq"', 1001, true);
          public          postgres    false    211            V           0    0    User_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."User_id_seq"', 1004, true);
          public          postgres    false    213            W           0    0    event_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.event_id_seq', 5007, true);
          public          postgres    false    220            X           0    0    movie_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.movie_id_seq', 1003, true);
          public          postgres    false    219            �           2606    17007    Event Event_id 
   CONSTRAINT     P   ALTER TABLE ONLY public."Event"
    ADD CONSTRAINT "Event_id" PRIMARY KEY (id);
 <   ALTER TABLE ONLY public."Event" DROP CONSTRAINT "Event_id";
       public            postgres    false    209            �           2606    17128    Movie_Order Movie_Order_id 
   CONSTRAINT     \   ALTER TABLE ONLY public."Movie_Order"
    ADD CONSTRAINT "Movie_Order_id" PRIMARY KEY (id);
 H   ALTER TABLE ONLY public."Movie_Order" DROP CONSTRAINT "Movie_Order_id";
       public            postgres    false    217            �           2606    17147    Movie Movie_id 
   CONSTRAINT     P   ALTER TABLE ONLY public."Movie"
    ADD CONSTRAINT "Movie_id" PRIMARY KEY (id);
 <   ALTER TABLE ONLY public."Movie" DROP CONSTRAINT "Movie_id";
       public            postgres    false    218            �           2606    17116    Event_Order Order_Event_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."Event_Order"
    ADD CONSTRAINT "Order_Event_pkey" PRIMARY KEY (id);
 J   ALTER TABLE ONLY public."Event_Order" DROP CONSTRAINT "Order_Event_pkey";
       public            postgres    false    215            �           2606    17043    Role Role_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public."Role"
    ADD CONSTRAINT "Role_pkey" PRIMARY KEY (id);
 <   ALTER TABLE ONLY public."Role" DROP CONSTRAINT "Role_pkey";
       public            postgres    false    212            �           2606    17052    User User_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY (id);
 <   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_pkey";
       public            postgres    false    214            �           2606    17073    User User_role_id_fkey    FK CONSTRAINT     z   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_role_id_fkey" FOREIGN KEY (role_id) REFERENCES public."Role"(id);
 D   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_role_id_fkey";
       public          postgres    false    214    212    3242            ?   �  x�͓Mo� ���+F�$�l�UUU{X�J�&�5���x�m�}qv%iR�=EB�� �y���r��
VW��M�`$:Y��O�̨����@� �q��1��JqP��\��4I�E��Z�&��u����y���Q}�l���㧯�K8��Nup��Ӥzq;�V�Q�`�^��ނ�/�a/�7�߈��H���p����BWb/��6&n�~
�K;�T"�vWLE�Ғ�-����(�4'$'-вôc%"UEy�Z���v��0&O,�Y��w��"����`0������vk��!i0�j�?Q4?�Q���_Ln�B�b�KAH!��mZ,��ӵ\�=�׽�mCʆ7��m�@�qT�Y�zs �sx�A�y�x�x¿�������Y뒭s����UN�r��W����$�fe�|������>�l���N\�      E     x�͑�j�@��y�!����Z���z��&�a�nÂQ�-}�n<4P���~惟�f�b�=m!/�k��ZW�<�P�ݯ{��9,�$���)F�c0V���z%��{a��O~Dc��" ��иɛ����w��RJ�Sp	x]�V��E��+�VHi�>�qtOR�Z�X�y��Y���8
�?	��aȧ �m�`�F��l'���=�E!E6I��w�o�˿Ô�c� �d���lx��;��)���|h?��Ҕ�(������7���      H   {  x�Ց�N�0E�����R��NҤe��J�D�ʱ�֐��vx��ء�ꚍg�\�Z���^�߭`q���U�d�ɕz��F�GफE\Xf�vR�Ԋ��S���z�S��#�h#����)G#��z������O`F����E�i����pvy��FE0����-dx�e��h@j�5`���h#\pߟ�I!�'8�*� �ҧe!q眶�$a����%�<�t�(�I��0�h#�<!����QoC�e�6�uԾ������ 2G�<#1��$-������ ��+���`0I�#�h-6��P��RL�P�~�.v�-py��Z'Z��(�$%hS,��*�YI
�yɊ�j�z���QT���,KIJ���`��S�      G   �  x�͕Mk�0�����4��}X�zZ��)4�J�ȶ�8v�[��~U�)KQ{J@�A�i�ьf�������d�g���ɏ����Ma�rꊈ���W�om3mg���H�X����t^\���T��^"bVu_��GW�	�����tAN@D��?���mێ�ɀ�3�3�1͹FA�>�Ҡ��\�/���ߵ]�������*kS��+W������3K�rc]��4ힳ��|4; 9��R��*���w&a/��~������@m ���c �@��q��*�OA8 ɦ&� @J�QQ����*��B&Ҋ��bƘ)朧������P�[)��2�\%<�zgB�y;tt|���.�S&��G��q�"��F�<�����S:�x+c}�#g�Mȗ!P�Hv��-�kj4��L.�      B   �   x���v
Q���W((M��L�S
��IUR��L�Q�K�M�QH.JM,IM�O,�Q(-H��5�}B]�4t�!�Ձ,###]CC]##+#C+#=K#sC���\�Tr�!ЦĔ��<�VZ虚��p\� .. �+J�      D     x�ŒK��0����Ѝ-���8F3��E�Ё�c[�*������*#]v�p�wHx8�N$<��I�EY;�s��٦�E�2S�At�+d�,Rɦ��Z{�Y�2ʹ}+=Ei��,�J�*��V?��I�����?�-P��7���ˬ�ZsVU��1d?�4'.sm� �G�h���y)�(��;�!ؓ���_V���R&yZ����Z��c ٝR�?�@(o�@�	8�l_ڊ;s:q���B�|�Y��.s8�^�_o5�a����     