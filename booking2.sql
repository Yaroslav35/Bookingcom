-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Дек 23 2024 г., 18:54
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `booking2`
--

-- --------------------------------------------------------

--
-- Структура таблицы `booking`
--

CREATE TABLE IF NOT EXISTS `booking` (
  `user` varchar(20) NOT NULL,
  `dateFrom` date NOT NULL,
  `dateTo` date NOT NULL,
  `room_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `cities`
--

CREATE TABLE IF NOT EXISTS `cities` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=16 ;

--
-- Дамп данных таблицы `cities`
--

INSERT INTO `cities` (`id`, `Name`) VALUES
(1, 'Ульяновск'),
(2, 'Москва'),
(3, 'Самара'),
(4, 'Казань'),
(5, 'Санкт-Петербург'),
(6, 'Краснодар'),
(7, 'Димитровград'),
(10, 'Красноярск'),
(13, 'Ханты-Мансийск'),
(14, 'Тольятти'),
(15, 'Астрахань');

-- --------------------------------------------------------

--
-- Структура таблицы `hotels`
--

CREATE TABLE IF NOT EXISTS `hotels` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `rating` int(11) NOT NULL,
  `id_city` int(11) NOT NULL,
  `image` varchar(50) NOT NULL,
  `adress` varchar(200) NOT NULL,
  `tel` varchar(50) NOT NULL,
  `opis` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=22 ;

--
-- Дамп данных таблицы `hotels`
--

INSERT INTO `hotels` (`id`, `name`, `rating`, `id_city`, `image`, `adress`, `tel`, `opis`) VALUES
(1, 'Гостиница Венец', 3, 1, 'Гостиница Венец.jpg', 'г. Ульяновск, ул. Спасская, д.19/9', '+7 (921) 307-40-18', 'Гостиница "Венец" в Ульяновске - это идеальное место для комфортного и приятного проживания. Мы предлагаем широкий выбор номеров разных категорий, чтобы удовлетворить потребности каждого гостя.\r\nНаша гостиница предлагает стандартные двухместные номера с двумя односпальными кроватями, номера комфорт с одной или двумя односпальными кроватями, улучшенные двухместные номера с одной двуспальной кроватью, улучшенные номера полулюкс и семейные номера с гостиной и спальней. Кроме того, мы предлагаем апа'),
(2, 'Гостиница Волга', 2, 1, 'Гостиница Волга.jpg', 'г. Ульяновск, ул. Гончарова, д. 3/38', '+7 (8422) 30-59-49', 'Гостиница «Волга» удобно расположена в деловой и исторической части Ульяновска, на центральной и самой красивой улице города – улице Гончарова. Из окон большинства номеров гостиницы можно наслаждаться красотой и величием реки Волги. Удачное расположение позволяет посетителям гостиницы совмещать насыщенные деловые будни с разнообразной культурно-развлекательной программой. Рядом c гостиницей находятся наиболее значимые объекты деловой, культурной и развлекательной жизни Ульяновска.'),
(3, 'Гостиница Мираж', 4, 1, 'Гостиница Мираж.jpg', 'г. Ульяновск, проспект Врача Сурова, д. 28', '+7 (8422) 56-04-04', 'Официально «Мираж» открыт с 2024 года. Отель с хорошо развитой инфраструктурой идеально подойдет для комфортного отдыха в деловой и туристической поездке, а также проведения корпоративных мероприятий. В распоряжении гостей отеля: 80 номеров различных категорий, комфортные условия для маломобильных групп населения, конгресс услуги, спортивно-оздоровительные кабинеты, ресторан «Ривьера» и лобби-бар.'),
(4, 'Гостиница Космос', 5, 2, 'Гостиница Космос.jpg', 'г. Москва, просп. Мира, д. 150', '+7 (495) 234-10-00', 'Cosmos Moscow VDNH Hotel - это не только самый большой отель Европы, но и уникальный выбор для проведения самых важных и масштабных событий: концертов, фестивалей, выставок, свадеб, банкетов и вечеринок.\r\n\r\nCosmos Moscow VDNH Hotel — выгодное расположение - 2 минуты от станции метро "ВДНХ" и 10 минут до центра, номера различных категорий по доступной цене, потрясающие панорамные виды Москвы: на Музей космонавтики, ВДНХ, Останкинскую телебашню, Москва-Сити и многое другое.'),
(5, 'Бета Измайлово Гостиница', 3, 2, 'Бета Измайлово.jpg', 'г. Москва, Измайловское ш., 71, корп. 2Б', '+7 (495) 792-98-50', 'Официальное бронированию номеров и обслуживание корпоративных клиентов в отеле Бета Измайлово.\r\n\r\nМы рады приветствовать Вас! Гостиничный комплекс Измайлово *** (3 звезды), Москва.\r\n\r\nУ нас Вы встретите вежливое и внимательное отношение обслуживающего персонала. Сможете оценить качество нематериальных услуг. Добро пожаловать в гостиницу Измайловская, и мы надеемся, что Вы унесете с собой воспоминание, которым сможете поделиться с другими.'),
(6, 'HolidayHall', 4, 3, 'HolidayHall.jpg', 'Самара, ул. Алексея Толстого, д. 99', '+7 (846) 372-70-00', 'Исключительная локация, комфортабельные номера, колоссальные конференц-возможности и широкий набор дополнительных услуг делают HolidayHall Samara идеальным местом как для деловых путешественников, так и для туристов, желающих провести выходные в городе на Волге.'),
(11, 'Бристоль-Жигули', 3, 3, 'Бристоль-Жигули.jpg', 'г. Самара, ул. Куйбышева, д. 111', '+7 (846) 331-20-00', 'Высококлассный отель в центре города, занимающий старинное здание эпохи модерн XIX века.'),
(12, 'Отель Щука', 2, 15, 'caption.jpg', 'Астрахань, ул. Лейтенанта Шмидта, 5 А', '+7 (111) 111-11-11', 'Здание гостиницы находится в самом сердце Астрахани: в радиусе 5 минут ходьбы располагаются самые главные достопримечательности города: астраханский кремль, центральные площади: Ленина и Октябрьская, Лебединое озеро и центральная набережная. Все номера оснащены всем необходимым для комфортного отдыха. '),
(13, 'Маринс Гранд Отель Астрахань', 5, 15, 'Маринс Гранд Отель Астрахань.jpg', 'Астрахань, ул. Куйбышева, 69', '+7 (111) 111-11-11', 'Бизнес-отель премиум класса в центре Астрахани около Кремля. Одной из особенностей отеля является расположение на живописном берегу Волги вблизи административного и делового центра города. Архитектурной изюминкой проекта являются стеклянные витражи. Рядом расположены: Театр оперы и балета, Музыкальный театр, Театр Юного зрителя, Астраханский городской исторический музей, Музей боевой славы. До аэропорта — 11 км, до ж/д вокзала — 2,4 км. '),
(14, 'Сказка', 3, 7, 'Бета Измайлово.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(15, 'Радуга', 2, 7, 'Бета Измайлово.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(16, 'Татарстан', 3, 4, 'HolidayHall.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(17, 'Cosmos Kazan Hotel', 4, 4, 'HolidayHall.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(18, 'Арго', 4, 6, 'Бристоль-Жигули.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(19, 'Матрон Palace', 4, 6, 'Бристоль-Жигули.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(20, 'Ермак', 3, 10, 'Гостиница Волга.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]'),
(21, 'Октябрьская', 2, 10, 'Гостиница Волга.jpg', 'Null Adress', '+7 (111) 11-11-11', '[Описание гостиницы]');

-- --------------------------------------------------------

--
-- Структура таблицы `rooms`
--

CREATE TABLE IF NOT EXISTS `rooms` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `id_hotel` int(11) NOT NULL,
  `image` varchar(50) NOT NULL,
  `price` int(11) NOT NULL,
  `space` int(11) NOT NULL,
  `opis` varchar(500) NOT NULL,
  `kol` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=32 ;

--
-- Дамп данных таблицы `rooms`
--

INSERT INTO `rooms` (`id`, `name`, `id_hotel`, `image`, `price`, `space`, `opis`, `kol`) VALUES
(1, 'Стандартный одноместный номер', 1, 'Stand_odn_Venec.jpg', 2550, 16, 'Услуги в номере: Телевизор, Wi-Fi', 5),
(2, 'Улучшенный одноместный номер', 1, 'Uluch_odn_Venec.jpg', 3200, 19, 'Услуги в номере: Телевизор, Wi-Fi', 6),
(3, 'Стандарт Семейный', 2, 'Stand_semey_Volga.jpg', 3210, 25, 'Уютный однокомнатный трёх/четырёхместный номер с рабочей зоной.', 4),
(4, 'Стандартный', 4, 'Stand_Cosmos.jpg', 5092, 24, 'Однокомнатный номер с одной большой или двумя раздельными кроватями прекрасно подходит для бизнес-поездок. В номере к вашим услугам: ванная комната, гардероб, стол, мини-холодильник, ТВ, Wi-Fi', 10),
(5, 'Одноместный', 11, 'Stand_odn_Venec.jpg', 10000, 40, 'Хороший номер', 10),
(6, 'Одноместный Стандартный', 3, 'Одноместный номер.jpg', 3500, 26, 'Одноместный номер с телевизором', 10),
(7, 'Стандартный номер', 5, 'standart1.jpg', 4500, 25, 'Просторный светлый номер (20-25 кв. м.) с уютной домашней атмосферой, для людей, ценящих свои деньги, и желающих получить максимум при минимуме затрат. Стандартный номер оборудован всем необходимым: большой телевизор с пультом дистанционного управления, телефон, большинство номеров оборудовано холодильником. Вы не переплачиваете за избыточный комфорт, тем не менее, получая все, что необходимо для нормального проживания.', 15),
(8, 'Номер стандарт с 1 двуспальной кроватью', 6, 'Номер стандарт.jpg', 3600, 25, 'Номер стандарт с 1 двуспальной кроватью queen-size (с завтраком)', 7),
(9, 'Номер с 1 двуспальной кроватью', 12, 'Номер с 1 двуспальной кроватью.jpg', 3200, 13, 'Фен, Душ, Отопление, Спутниковое/кабельное ТВ, Полотенца, Постельное белье, Гель для душа', 2),
(10, '2-местный номер стандарт', 12, '2-местный номер стандарт.jpg', 3400, 14, 'Душ, Фен, Отопление, Спутниковое/кабельное ТВ, Полотенца, Постельное белье, Собственный туалет', 19),
(11, '2-местный номер улучшенный', 12, '2-местный номер улучшенный.jpg', 3800, 18, 'Фен, Душ, Рабочее место, Спутниковое/кабельное ТВ, Отопление, Полотенца, Постельное белье', 1),
(12, 'Оптима с двуспальной кроватью', 13, 'Оптима с двуспальной кроватью.jpg', 4053, 22, 'Холодильник, Звукоизоляция, Рабочее место, Душ, Фен, Детская кроватка, Халат, Шторы-блэкаут', 4),
(13, 'Стандарт с двуспальной кроватью', 13, 'Стандарт с двуспальной кроватью.jpg', 4650, 27, 'Рабочее место, Звукоизоляция, Душ, Фен, Отопление, Спутниковое/кабельное ТВ, Шторы-блэкаут', 8),
(14, 'Стандарт Улучшенный с двуспальной кроватью', 13, 'Стандарт Улучшенный с двуспальной кроватью.jpg', 6300, 27, 'Фен, Звукоизоляция, Рабочее место, Спутниковое/кабельное ТВ, Розетка около кровати, \r\nДетская кроватка', 8),
(15, 'Стандартный двухместный номер', 1, 'Стандартный двухместный номер.jpg', 5200, 35, '[Описание номера]', 12),
(16, 'Одноместный', 14, 'Одноместный номер.jpg', 6900, 23, '[Описание номера]', 11),
(17, 'Двухместный номер', 14, 'Стандартный двухместный номер.jpg', 1000, 15, '[Описание номера]', 3),
(18, 'Одноместный номер', 15, 'Одноместный номер.jpg', 3270, 20, '[Описание номера]', 22),
(19, 'Двухместный номер', 15, 'Стандартный двухместный номер.jpg', 9800, 45, '[Описание номера]', 13),
(20, 'Одноместный номер', 16, 'Одноместный номер.jpg', 5400, 34, '[Описание номера]', 4),
(21, 'Двухместный номер', 16, 'Стандартный двухместный номер.jpg', 3400, 52, '[Описание номера]', 14),
(22, 'Одноместный номер', 17, 'Одноместный номер.jpg', 2100, 8, '[Описание номера]', 11),
(23, 'Двухместный номер', 17, 'Стандартный двухместный номер.jpg', 3000, 28, '[Описание номера]', 6),
(24, 'Одноместный номер', 18, 'Одноместный номер.jpg', 100, 17, '[Описание номера]', 9),
(25, 'Двухместный номер', 18, 'Стандартный двухместный номер.jpg', 200, 19, '[Описание номера]', 5),
(26, 'Одноместный номер', 19, 'Одноместный номер.jpg', 90000, 20, '[Описание номера]', 2),
(27, 'Двухместный номер', 19, 'Стандартный двухместный номер.jpg', 200000, 11, '[Описание номера]', 7),
(28, 'Одноместный номер', 20, 'Одноместный номер.jpg', 4000, 18, '[Описание номера]', 13),
(29, 'Двухместный номер', 20, 'Стандартный двухместный номер.jpg', 5100, 26, '[Описание номера]', 0),
(30, 'Одноместный номер', 21, 'Одноместный номер.jpg', 1400, 21, '[Описание номера]', 1),
(31, 'Двуместный номер', 21, 'Стандартный двухместный номер.jpg', 1700, 24, '[Описание номера]', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `name` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `admin` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`, `admin`) VALUES
(7, 'tezor', 'tezor1k', 'Ярослав', 'Тютюнник', 1),
(8, 'ya', '123', 'Ы', 'Ы', 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
