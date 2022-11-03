-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-06-2021 a las 23:44:16
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `reto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `Id` int(10) UNSIGNED NOT NULL,
  `nombre` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `clasificacion` enum('ninguno','pequenio','mediano','grande') COLLATE utf8_spanish_ci DEFAULT NULL,
  `direccion` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nit` varchar(17) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nrc` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL,
  `razon_social` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `giro` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `telefono` varchar(12) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`Id`, `nombre`, `clasificacion`, `direccion`, `nit`, `nrc`, `razon_social`, `giro`, `telefono`) VALUES
(1, 'Nombre del Cliente', 'ninguno', '', '708-899878-788-7', '1236547-8', '', '', ''),
(2, 'segundo Cliente', 'pequenio', 'Direccion inventada', '1695-227492-222-8', '987412-9', '', '', ''),
(3, 'diego', 'ninguno', '', '1223-222222-222-8', '123483-9', '', '', ''),
(4, 'Mario Armando Perez', 'pequenio', '', '1885-226492-255-8', '123456-1', '', '', '7778-9885'),
(5, 'Pedro Enrique Ramos Rivera', 'grande', '', '4559-567891-249-7', '987654-1', '', '', '2252-4585'),
(6, 'Mario Armando Lopez', 'mediano', 'San Salvador', '2793-223592-654-9', '254796-4', '', '', '9984-7863'),
(7, 'Luis Armando Rivera', 'pequenio', 'Direccion', '1247-222222-999-7', '123456-7', '', '', '2252-7898'),
(8, 'Juan', 'pequenio', '', '1211-222244-255-8', '123456-9', '', '', ''),
(9, 'Wilmer', 'pequenio', '', '0301-040189-104-0', '777548-9', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE `compra` (
  `Id` int(10) UNSIGNED NOT NULL,
  `afectas` decimal(12,2) DEFAULT NULL,
  `iva` decimal(10,2) DEFAULT NULL,
  `retencion` decimal(10,2) DEFAULT NULL,
  `proveedor` int(10) UNSIGNED DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `registrado_por` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `condiciones` int(10) UNSIGNED DEFAULT 0,
  `document_type` enum('ccf','fcf') COLLATE utf8_spanish_ci DEFAULT NULL,
  `document_number` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `compra`
--

INSERT INTO `compra` (`Id`, `afectas`, `iva`, `retencion`, `proveedor`, `fecha`, `registrado_por`, `condiciones`, `document_type`, `document_number`) VALUES
(21, '130.00', '16.90', '0.00', 6, '2021-06-19 00:00:00', 'Diego/Mario', 0, 'ccf', '1'),
(22, '106.00', '0.00', '0.00', 4, '2021-06-19 00:00:00', 'Diego/Mario', 0, 'fcf', '1'),
(23, '60.00', '7.80', '0.00', 6, '2021-06-19 00:00:00', 'Diego/Mario', 0, 'ccf', '3'),
(24, '1.00', '0.13', '0.00', 4, '2021-06-19 00:00:00', 'Diego/Mario', 0, 'ccf', '4'),
(25, '15.00', '1.95', '0.00', 7, '2021-06-19 00:00:00', 'Diego/Mario', 0, 'ccf', '5'),
(26, '12.50', '1.63', '0.00', 6, '2021-06-19 00:00:00', 'Diego/Mario', 0, 'ccf', '6');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `c_cuentas`
--

CREATE TABLE `c_cuentas` (
  `Id` int(10) UNSIGNED NOT NULL,
  `rubro` enum('ACTIVO','PASIVO','CAPITAL','COSTOS y GASTOS','INGRESOS') COLLATE utf8_spanish_ci DEFAULT NULL,
  `Agrupacion` enum('Activo corriente','Activo no corriente','Pasivo Corriente','Pasivo no Corriente','Costos','Gastos Operativos','Ingresos Ordinarios','Patrimonio') COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `codigo` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL,
  `debe` decimal(12,2) DEFAULT NULL,
  `haber` decimal(12,2) DEFAULT NULL,
  `tipo_saldo` enum('DEUDOR','ACREEDOR') COLLATE utf8_spanish_ci DEFAULT NULL,
  `cuenta_padre` int(10) UNSIGNED DEFAULT NULL,
  `nivel` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `c_cuentas`
--

INSERT INTO `c_cuentas` (`Id`, `rubro`, `Agrupacion`, `nombre`, `codigo`, `debe`, `haber`, `tipo_saldo`, `cuenta_padre`, `nivel`) VALUES
(2, 'ACTIVO', 'Activo corriente', 'Cuentas por cobrar', '1102', '0.00', '0.00', 'DEUDOR', 0, 3),
(7, 'ACTIVO', 'Activo corriente', 'Impuestos por cobrar', '1103', '799.89', '0.00', 'DEUDOR', 1, 3),
(8, 'ACTIVO', 'Activo corriente', 'Inventario', '1104', '324.50', '78.38', 'DEUDOR', 1, 3),
(9, 'ACTIVO', 'Activo corriente', 'Mercaderias', '110401', '0.00', '0.00', 'DEUDOR', 8, 4),
(10, 'ACTIVO', 'Activo corriente', 'Clientes', '110201', '0.00', '0.00', 'DEUDOR', 2, 4),
(12, 'ACTIVO', 'Activo corriente', 'Anticipos a proveedores y acreedores', '110203', '0.00', '0.00', 'DEUDOR', 2, 4),
(13, 'ACTIVO', 'Activo corriente', 'Crédito Fisca-IVA', '110301', '0.00', '0.00', 'DEUDOR', 7, 4),
(14, 'ACTIVO', 'Activo corriente', 'Retención y percepción IVA', '110302', '0.00', '0.00', 'DEUDOR', 7, 4),
(16, 'ACTIVO', 'Activo corriente', 'Propiedad, Planta y Equipo', '1201', '5924.77', '0.00', 'DEUDOR', 4, 3),
(17, 'ACTIVO', 'Activo corriente', 'Terrenos', '120101', '0.00', '0.00', 'DEUDOR', 16, 4),
(18, 'ACTIVO', 'Activo corriente', 'Edificios', '120102', '0.00', '0.00', 'DEUDOR', 16, 4),
(19, 'ACTIVO', 'Activo corriente', 'Muebles', '120103', '0.00', '0.00', 'DEUDOR', 16, 4),
(20, 'ACTIVO', 'Activo corriente', 'Equipo de transporte', '120104', '0.00', '0.00', 'DEUDOR', 16, 4),
(22, 'PASIVO', 'Pasivo Corriente', 'Proveedores', '210101', '0.00', '0.00', 'ACREEDOR', 21, 4),
(23, 'PASIVO', 'Pasivo Corriente', 'Acreedores', '210102', '0.00', '0.00', 'ACREEDOR', 21, 4),
(24, 'PASIVO', 'Pasivo Corriente', 'Retenciones legales y beneficios a empleados', '210103', '0.00', '0.00', 'ACREEDOR', 21, 4),
(26, 'PASIVO', 'Pasivo Corriente', 'Prestamos bancarios', '210104', '0.00', '0.00', 'ACREEDOR', 21, 4),
(27, 'PASIVO', 'Pasivo Corriente', 'Cuentas por pagar', '2101', '0.00', '5000.00', 'ACREEDOR', 25, 3),
(28, 'PASIVO', 'Pasivo Corriente', 'Impuestos por pagar', '2102', '0.00', '37.17', 'ACREEDOR', 25, 3),
(29, 'PASIVO', 'Pasivo Corriente', 'Débito Fiscal-IVA', '210201', '0.00', '0.00', 'ACREEDOR', 28, 4),
(30, 'PASIVO', 'Pasivo Corriente', 'Impuesto sobre la renta', '210202', '0.00', '0.00', 'ACREEDOR', 28, 4),
(31, 'ACTIVO', 'Activo corriente', 'Efectivo y Equivalente', '1101', '5321.87', '2047.91', 'DEUDOR', 1, 3),
(32, 'PASIVO', 'Pasivo no Corriente', 'Cuentas por pagar LP', '2201', '0.00', '0.00', 'ACREEDOR', 1, 3),
(33, 'CAPITAL', '', 'Cuenta capital', '3101', '0.00', '5000.00', 'ACREEDOR', 0, 3),
(34, 'CAPITAL', '', 'Utilidad/Perdida del ejercicio', '3102', '0.00', '0.00', 'ACREEDOR', 0, 3),
(35, 'CAPITAL', '', 'Resultados Acumulados', '3103', '0.00', '0.00', 'ACREEDOR', 0, 3),
(36, 'COSTOS y GASTOS', 'Costos', 'Costo de Ventas', '4101', '78.38', '0.00', 'DEUDOR', 0, 3),
(37, 'COSTOS y GASTOS', 'Gastos Operativos', 'Gastos de Ventas', '4201', '0.00', '0.00', 'DEUDOR', 36, 3),
(38, 'COSTOS y GASTOS', 'Gastos Operativos', 'Gastos de Administración', '4202', '0.00', '0.00', 'DEUDOR', 36, 3),
(39, 'INGRESOS', 'Ingresos Ordinarios', 'Ingresos por ventas', '5101', '0.00', '285.95', 'ACREEDOR', 36, 3),
(40, 'INGRESOS', 'Ingresos Ordinarios', 'Otros Ingresos', '5102', '0.00', '0.00', 'ACREEDOR', 36, 3),
(45, 'ACTIVO', 'Activo corriente', 'cuenta prueba', '11010102', '0.00', '0.00', 'DEUDOR', 3, 5),
(46, 'ACTIVO', 'Activo corriente', 'Banco', '110102', '0.00', '0.00', 'DEUDOR', 31, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `c_detallepartida`
--

CREATE TABLE `c_detallepartida` (
  `Id` int(10) UNSIGNED NOT NULL,
  `partidaId` int(10) UNSIGNED NOT NULL,
  `cuentaId` int(10) UNSIGNED NOT NULL,
  `debe` decimal(12,2) DEFAULT NULL,
  `haber` decimal(12,2) DEFAULT NULL,
  `parcial` decimal(12,2) DEFAULT NULL,
  `padre` int(10) UNSIGNED DEFAULT NULL,
  `saldo_anterior` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `c_detallepartida`
--

INSERT INTO `c_detallepartida` (`Id`, `partidaId`, `cuentaId`, `debe`, `haber`, `parcial`, `padre`, `saldo_anterior`) VALUES
(70, 49, 7, '16.90', '0.00', NULL, NULL, '0.00'),
(71, 49, 8, '130.00', '0.00', NULL, NULL, '0.00'),
(72, 49, 31, '0.00', '146.90', NULL, NULL, '0.00'),
(73, 50, 7, '0.00', '0.00', NULL, NULL, '16.90'),
(74, 50, 8, '106.00', '0.00', NULL, NULL, '130.00'),
(75, 50, 31, '0.00', '106.00', NULL, NULL, '-146.90'),
(76, 51, 31, '3.16', '0.00', NULL, NULL, '-252.90'),
(77, 51, 28, '0.00', '0.36', NULL, NULL, '0.00'),
(78, 51, 39, '0.00', '2.80', NULL, NULL, '0.00'),
(79, 52, 36, '2.25', '0.00', NULL, NULL, '0.00'),
(80, 52, 8, '0.00', '2.25', NULL, NULL, '236.00'),
(81, 53, 31, '28.25', '0.00', NULL, NULL, '-249.74'),
(82, 53, 28, '0.00', '3.25', NULL, NULL, '0.36'),
(83, 53, 39, '0.00', '25.00', NULL, NULL, '2.80'),
(84, 54, 36, '5.60', '0.00', NULL, NULL, '2.25'),
(85, 54, 8, '0.00', '5.60', NULL, NULL, '233.75'),
(86, 55, 31, '43.79', '0.00', NULL, NULL, '-221.49'),
(87, 55, 28, '0.00', '5.04', NULL, NULL, '3.61'),
(88, 55, 39, '0.00', '38.75', NULL, NULL, '27.80'),
(89, 56, 36, '7.75', '0.00', NULL, NULL, '7.85'),
(90, 56, 8, '0.00', '7.75', NULL, NULL, '228.15'),
(91, 57, 31, '140.00', '0.00', NULL, NULL, '-177.70'),
(92, 57, 7, '1.25', '0.00', NULL, NULL, '16.90'),
(93, 57, 28, '0.00', '16.25', NULL, NULL, '8.65'),
(94, 57, 39, '0.00', '125.00', NULL, NULL, '66.55'),
(95, 58, 36, '28.00', '0.00', NULL, NULL, '15.60'),
(96, 58, 8, '0.00', '28.00', NULL, NULL, '220.40'),
(97, 59, 7, '195.00', '0.00', NULL, NULL, '18.15'),
(98, 59, 16, '1500.00', '0.00', NULL, NULL, '0.00'),
(99, 59, 31, '0.00', '1695.00', NULL, NULL, '-37.70'),
(100, 60, 7, '7.80', '0.00', NULL, NULL, '213.15'),
(101, 60, 8, '60.00', '0.00', NULL, NULL, '192.40'),
(102, 60, 31, '0.00', '67.80', NULL, NULL, '-1732.70'),
(103, 61, 7, '0.13', '0.00', NULL, NULL, '220.95'),
(104, 61, 8, '1.00', '0.00', NULL, NULL, '252.40'),
(105, 61, 31, '0.00', '1.13', NULL, NULL, '-1800.50'),
(106, 62, 31, '14.12', '0.00', NULL, NULL, '-1801.63'),
(107, 62, 28, '0.00', '1.62', NULL, NULL, '24.90'),
(108, 62, 39, '0.00', '12.50', NULL, NULL, '191.55'),
(109, 63, 36, '4.06', '0.00', NULL, NULL, '43.60'),
(110, 63, 8, '0.00', '4.06', NULL, NULL, '253.40'),
(111, 64, 7, '1.95', '0.00', NULL, NULL, '221.08'),
(112, 64, 8, '15.00', '0.00', NULL, NULL, '249.34'),
(113, 64, 31, '0.00', '16.95', NULL, NULL, '-1787.51'),
(114, 65, 31, '70.62', '0.00', NULL, NULL, '-1804.46'),
(115, 65, 28, '0.00', '8.12', NULL, NULL, '26.52'),
(116, 65, 39, '0.00', '62.50', NULL, NULL, '204.05'),
(117, 66, 36, '22.50', '0.00', NULL, NULL, '47.66'),
(118, 66, 8, '0.00', '22.50', NULL, NULL, '264.34'),
(119, 67, 7, '575.23', '0.00', NULL, NULL, '223.03'),
(120, 67, 16, '4424.77', '0.00', NULL, NULL, '1500.00'),
(121, 67, 27, '0.00', '5000.00', NULL, NULL, '0.00'),
(122, 68, 31, '5000.00', '0.00', NULL, NULL, '-1733.84'),
(123, 68, 33, '0.00', '5000.00', NULL, NULL, '0.00'),
(124, 69, 31, '13.45', '0.00', NULL, NULL, '3266.16'),
(125, 69, 28, '0.00', '1.55', NULL, NULL, '34.64'),
(126, 69, 39, '0.00', '11.90', NULL, NULL, '266.55'),
(127, 70, 36, '2.50', '0.00', NULL, NULL, '70.16'),
(128, 70, 8, '0.00', '2.50', NULL, NULL, '241.84'),
(129, 71, 7, '1.63', '0.00', NULL, NULL, '798.26'),
(130, 71, 8, '12.50', '0.00', NULL, NULL, '239.34'),
(131, 71, 31, '0.00', '14.13', NULL, NULL, '3279.61'),
(132, 72, 31, '8.48', '0.00', NULL, NULL, '3265.48'),
(133, 72, 28, '0.00', '0.98', NULL, NULL, '36.19'),
(134, 72, 39, '0.00', '7.50', NULL, NULL, '278.45'),
(135, 73, 36, '5.72', '0.00', NULL, NULL, '72.66'),
(136, 73, 8, '0.00', '5.72', NULL, NULL, '251.84');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `c_partida`
--

CREATE TABLE `c_partida` (
  `Id` int(10) UNSIGNED NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `debe` decimal(12,2) DEFAULT NULL,
  `haber` decimal(12,2) DEFAULT NULL,
  `descripcion` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `compra_relacionada` int(10) UNSIGNED DEFAULT NULL,
  `venta_relacionada` int(10) UNSIGNED DEFAULT NULL,
  `plantilla_predeterminada` int(10) UNSIGNED DEFAULT NULL,
  `partida_reversion` int(10) UNSIGNED DEFAULT NULL,
  `partida_revertida` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `c_partida`
--

INSERT INTO `c_partida` (`Id`, `fecha`, `debe`, `haber`, `descripcion`, `compra_relacionada`, `venta_relacionada`, `plantilla_predeterminada`, `partida_reversion`, `partida_revertida`) VALUES
(49, '2021-06-19 00:00:00', '276.90', '276.90', 'Compra a Almacenes Ana con CCF # 1', 21, 0, NULL, NULL, NULL),
(50, '2021-06-19 00:00:00', '225.78', '225.78', 'Compra a Siman con FCF # 1', 22, 0, NULL, NULL, NULL),
(51, '2021-06-19 00:00:00', '3.16', '3.16', 'Venta a Mario Armando Perez con fcf #1', 0, 66, NULL, NULL, NULL),
(52, '2021-06-19 00:00:00', '2.25', '2.25', 'Costo de la venta a Mario Armando Perez con fcf #1', 0, 66, NULL, NULL, NULL),
(53, '2021-06-19 00:00:00', '28.25', '28.25', 'Venta a Pedro Enrique Ramos Rivera con ccf #1', 0, 67, NULL, NULL, NULL),
(54, '2021-06-19 00:00:00', '5.60', '5.60', 'Costo de la venta a Pedro Enrique Ramos Rivera con ccf #1', 0, 67, NULL, NULL, NULL),
(55, '2021-06-19 00:00:00', '43.79', '43.79', 'Venta a Mario Armando Lopez con ccf #2', 0, 68, NULL, NULL, NULL),
(56, '2021-06-19 00:00:00', '7.75', '7.75', 'Costo de la venta a Mario Armando Lopez con ccf #2', 0, 68, NULL, NULL, NULL),
(57, '2021-06-19 00:00:00', '140.00', '140.00', 'Venta a Pedro Enrique Ramos Rivera con ccf #3', 0, 69, NULL, NULL, NULL),
(58, '2021-06-19 00:00:00', '28.00', '28.00', 'Costo de la venta a Pedro Enrique Ramos Rivera con ccf #3', 0, 69, NULL, NULL, NULL),
(59, '2021-06-19 11:50:08', '1695.00', '1695.00', 'Compra de escritorio y sillas', 0, 0, NULL, NULL, NULL),
(60, '2021-06-19 00:00:00', '127.80', '127.80', 'Compra a Almacenes Ana con CCF # 3', 23, 0, NULL, NULL, NULL),
(61, '2021-06-19 00:00:00', '2.13', '2.13', 'Compra a Siman con CCF # 4', 24, 0, NULL, NULL, NULL),
(62, '2021-06-19 00:00:00', '14.12', '14.12', 'Venta a Mario Armando Perez con ccf #4', 0, 70, NULL, NULL, NULL),
(63, '2021-06-19 00:00:00', '4.06', '4.06', 'Costo de la venta a Mario Armando Perez con ccf #4', 0, 70, NULL, NULL, NULL),
(64, '2021-06-19 00:00:00', '31.95', '31.95', 'Compra a Sarita con CCF # 5', 25, 0, NULL, NULL, NULL),
(65, '2021-06-19 00:00:00', '70.62', '70.62', 'Venta a Mario Armando Lopez con ccf #5', 0, 71, NULL, NULL, NULL),
(66, '2021-06-19 00:00:00', '22.50', '22.50', 'Costo de la venta a Mario Armando Lopez con ccf #5', 0, 71, NULL, NULL, NULL),
(67, '2021-06-19 13:33:51', '5000.00', '5000.00', 'Compra de vehiculo', 0, 0, NULL, NULL, NULL),
(68, '2021-06-19 13:55:50', '5000.00', '5000.00', 'Aporte de Capital', 0, 0, NULL, NULL, NULL),
(69, '2021-06-19 00:00:00', '13.45', '13.45', 'Venta a Mario Armando Lopez con fcf #2', 0, 72, NULL, NULL, NULL),
(70, '2021-06-19 00:00:00', '2.50', '2.50', 'Costo de la venta a Mario Armando Lopez con fcf #2', 0, 72, NULL, NULL, NULL),
(71, '2021-06-19 00:00:00', '26.63', '26.63', 'Compra a Almacenes Ana con CCF # 6', 26, 0, NULL, NULL, NULL),
(72, '2021-06-19 00:00:00', '8.48', '8.48', 'Venta a Wilmer con ccf #6', 0, 73, NULL, NULL, NULL),
(73, '2021-06-19 00:00:00', '5.72', '5.72', 'Costo de la venta a Wilmer con ccf #6', 0, 73, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `c_saldo`
--

CREATE TABLE `c_saldo` (
  `Id` int(10) UNSIGNED NOT NULL,
  `cuentaId` int(10) UNSIGNED NOT NULL,
  `debe` decimal(12,2) DEFAULT NULL,
  `haber` decimal(12,2) DEFAULT 0.00,
  `hasta` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_compra`
--

CREATE TABLE `detalle_compra` (
  `Id` int(10) UNSIGNED NOT NULL,
  `compra` int(10) UNSIGNED NOT NULL,
  `producto` int(10) UNSIGNED DEFAULT NULL,
  `cant` int(10) UNSIGNED NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `detalle_compra`
--

INSERT INTO `detalle_compra` (`Id`, `compra`, `producto`, `cant`, `precio`) VALUES
(15, 21, 7, 100, '0.45'),
(16, 21, 6, 100, '0.40'),
(17, 21, 4, 100, '0.45'),
(18, 22, 8, 100, '0.56'),
(19, 22, 9, 100, '0.25'),
(20, 22, 10, 100, '0.25'),
(21, 23, 11, 100, '0.60'),
(22, 24, 6, 1, '1.00'),
(23, 25, 6, 3, '5.00'),
(24, 26, 7, 50, '0.25');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_documento`
--

CREATE TABLE `detalle_documento` (
  `Id` int(10) UNSIGNED NOT NULL,
  `documento` int(10) UNSIGNED NOT NULL,
  `producto` int(10) UNSIGNED DEFAULT NULL,
  `cant` int(10) UNSIGNED NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `detalle_documento`
--

INSERT INTO `detalle_documento` (`Id`, `documento`, `producto`, `cant`, `precio`) VALUES
(43, 66, 7, 5, '0.56'),
(44, 67, 8, 10, '2.50'),
(45, 68, 9, 31, '1.25'),
(46, 69, 8, 50, '2.50'),
(47, 70, 6, 10, '1.25'),
(48, 71, 4, 50, '1.25'),
(49, 72, 10, 10, '1.19'),
(50, 73, 7, 15, '0.50');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documento`
--

CREATE TABLE `documento` (
  `Id` int(10) UNSIGNED NOT NULL,
  `numero` int(10) UNSIGNED DEFAULT NULL,
  `serie` int(10) UNSIGNED DEFAULT NULL,
  `cliente` int(10) UNSIGNED DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `documento_anterior` int(10) UNSIGNED DEFAULT NULL,
  `anulada_por` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `anulada_en` datetime DEFAULT NULL,
  `motivo_anulacion` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `afectas` decimal(12,2) DEFAULT NULL,
  `exentas` decimal(12,2) DEFAULT NULL,
  `iva` decimal(11,2) DEFAULT 13.00,
  `retencion` decimal(11,2) DEFAULT 0.00,
  `percepcion` decimal(11,2) NOT NULL DEFAULT 0.00,
  `condiciones` int(10) UNSIGNED DEFAULT 0,
  `datos_cliente` text COLLATE utf8_spanish_ci DEFAULT NULL,
  `nota_remision` int(10) UNSIGNED DEFAULT NULL,
  `creacion` datetime DEFAULT NULL,
  `creado_por` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `caso` enum('afectas','exentas') COLLATE utf8_spanish_ci DEFAULT NULL,
  `Tipo_documento` varchar(4) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `documento`
--

INSERT INTO `documento` (`Id`, `numero`, `serie`, `cliente`, `fecha`, `documento_anterior`, `anulada_por`, `anulada_en`, `motivo_anulacion`, `afectas`, `exentas`, `iva`, `retencion`, `percepcion`, `condiciones`, `datos_cliente`, `nota_remision`, `creacion`, `creado_por`, `caso`, `Tipo_documento`) VALUES
(66, 1, 2, 4, '2021-06-19 11:43:07', NULL, NULL, NULL, NULL, '2.80', '0.00', '0.36', '0.00', '0.00', 0, '{\"registro\":\"123456-1\",\"nit\":\"1885-226492-255-8\",\"Direccion\":\"Santa Tecla\"}', NULL, '2021-06-19 11:43:54', 'Diego/Mario', NULL, 'fcf'),
(67, 1, 1, 5, '2021-06-19 11:44:09', NULL, NULL, NULL, NULL, '25.00', '0.00', '3.25', '0.00', '0.00', 0, '{\"registro\":\"987654-1\",\"nit\":\"4559-567891-249-7\",\"Direccion\":\"San Salvador\"}', NULL, '2021-06-19 11:44:36', 'Diego/Mario', NULL, 'ccf'),
(68, 2, 1, 6, '2021-06-19 11:44:59', NULL, NULL, NULL, NULL, '38.75', '0.00', '5.04', '0.00', '0.00', 0, '{\"registro\":\"254796-4\",\"nit\":\"2793-223592-654-9\",\"Direccion\":\"San Salvador\"}', NULL, '2021-06-19 11:45:37', 'Diego/Mario', NULL, 'ccf'),
(69, 3, 1, 5, '2021-06-19 11:45:56', NULL, NULL, NULL, NULL, '125.00', '0.00', '16.25', '1.25', '0.00', 0, '{\"registro\":\"987654-1\",\"nit\":\"4559-567891-249-7\",\"Direccion\":\"\"}', NULL, '2021-06-19 11:46:29', 'Diego/Mario', NULL, 'ccf'),
(70, 4, 1, 4, '2021-06-19 12:30:57', NULL, NULL, NULL, NULL, '12.50', '0.00', '1.62', '0.00', '0.00', 0, '{\"registro\":\"123456-1\",\"nit\":\"1885-226492-255-8\",\"Direccion\":\"Santa Tecla\"}', NULL, '2021-06-19 12:34:02', 'Diego/Mario', NULL, 'ccf'),
(71, 5, 1, 6, '2021-06-19 13:25:00', NULL, NULL, NULL, NULL, '62.50', '0.00', '8.12', '0.00', '0.00', 0, '{\"registro\":\"254796-4\",\"nit\":\"2793-223592-654-9\",\"Direccion\":\"San Salvador\"}', NULL, '2021-06-19 13:28:23', 'Diego/Mario', NULL, 'ccf'),
(72, 2, 2, 6, '2021-06-19 14:01:30', NULL, NULL, NULL, NULL, '11.90', '0.00', '1.55', '0.00', '0.00', 0, '{\"registro\":\"254796-4\",\"nit\":\"2793-223592-654-9\",\"Direccion\":\"San Salvador\"}', NULL, '2021-06-19 14:02:04', 'Diego/Mario', NULL, 'fcf'),
(73, 6, 1, 9, '2021-06-19 14:05:52', NULL, NULL, NULL, NULL, '7.50', '0.00', '0.98', '0.00', '0.00', 0, '{\"registro\":\"777548-9\",\"nit\":\"0301-040189-104-0\",\"Direccion\":\"Santa Ana\"}', NULL, '2021-06-19 14:06:44', 'Diego/Mario', NULL, 'ccf');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documento_serie`
--

CREATE TABLE `documento_serie` (
  `Id` int(10) UNSIGNED NOT NULL,
  `inicia_desde` int(10) UNSIGNED DEFAULT NULL,
  `termina_en` int(10) UNSIGNED DEFAULT NULL,
  `serie` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL,
  `tipo` enum('fcf','ccf','fex','nr','nc','nd') COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `documento_serie`
--

INSERT INTO `documento_serie` (`Id`, `inicia_desde`, `termina_en`, `serie`, `tipo`) VALUES
(1, 6, 1000, 'dsd1010f', 'ccf'),
(2, 2, 1000, 'cwf1010f', 'fcf'),
(3, 0, 1000, 'prt2343d', 'fex'),
(4, 0, 1000, 'jur5621t', 'nc'),
(5, 0, 1000, 'oqw8970t', 'nr'),
(6, 0, 1000, 'ppt6742t', 'nd'),
(11, 0, 100, 'ewredfda2', 'ccf');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `isr`
--

CREATE TABLE `isr` (
  `id` int(10) UNSIGNED NOT NULL,
  `de` decimal(12,2) DEFAULT NULL,
  `hasta` decimal(12,2) DEFAULT NULL,
  `porcentaje` int(11) DEFAULT NULL,
  `exceso` decimal(12,2) DEFAULT NULL,
  `cuota_fija` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `isr`
--

INSERT INTO `isr` (`id`, `de`, `hasta`, `porcentaje`, `exceso`, `cuota_fija`) VALUES
(1, '0.01', '4064.00', 0, '0.00', '0.00'),
(2, '4064.01', '9142.86', 10, '4064.00', '212.12'),
(3, '9142.87', '22857.14', 20, '9142.86', '720.00'),
(4, '22857.15', '0.00', 30, '22857.14', '3462.86');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento`
--

CREATE TABLE `movimiento` (
  `Id` int(10) UNSIGNED NOT NULL,
  `producto` int(10) UNSIGNED DEFAULT NULL,
  `cant` int(10) UNSIGNED DEFAULT NULL,
  `existencia_anterior` int(10) UNSIGNED DEFAULT 0,
  `precio` decimal(10,4) DEFAULT NULL,
  `costo` decimal(10,4) DEFAULT NULL,
  `costo_anterior` decimal(10,4) DEFAULT NULL,
  `tipo` char(1) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `cliente` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `doc` varchar(50) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `movimiento`
--

INSERT INTO `movimiento` (`Id`, `producto`, `cant`, `existencia_anterior`, `precio`, `costo`, `costo_anterior`, `tipo`, `fecha`, `cliente`, `doc`) VALUES
(55, 7, 100, 0, NULL, '0.4500', '0.0000', '1', '2021-06-19 11:33:13', 'Almacenes Ana', 'ccf # 1'),
(56, 6, 100, 0, NULL, '0.4000', '0.7500', '1', '2021-06-19 11:33:13', 'Almacenes Ana', 'ccf # 1'),
(57, 4, 100, 0, NULL, '0.4500', '0.5500', '1', '2021-06-19 11:33:13', 'Almacenes Ana', 'ccf # 1'),
(58, 8, 100, 0, NULL, '0.5600', '0.0000', '1', '2021-06-19 11:39:58', 'Siman', 'fcf # 1'),
(59, 9, 100, 0, NULL, '0.2500', '0.0000', '1', '2021-06-19 11:39:58', 'Siman', 'fcf # 1'),
(60, 10, 100, 0, NULL, '0.2500', '0.0000', '1', '2021-06-19 11:39:58', 'Siman', 'fcf # 1'),
(61, 7, 5, 100, NULL, '0.4500', '0.4500', '0', '2021-06-19 11:43:07', 'Mario Armando Perez', 'fcf # 1'),
(62, 8, 10, 100, NULL, '0.5600', '0.5600', '0', '2021-06-19 11:44:09', 'Pedro Enrique Ramos Rivera', 'ccf # 1'),
(63, 9, 31, 100, NULL, '0.2500', '0.2500', '0', '2021-06-19 11:44:59', 'Mario Armando Lopez', 'ccf # 2'),
(64, 8, 50, 90, NULL, '0.5600', '0.5600', '0', '2021-06-19 11:45:56', 'Pedro Enrique Ramos Rivera', 'ccf # 3'),
(65, 11, 100, 0, NULL, '0.6000', '0.0000', '1', '2021-06-19 12:08:12', 'Almacenes Ana', 'ccf # 3'),
(66, 6, 1, 100, NULL, '1.0000', '0.4000', '1', '2021-06-19 12:23:57', 'Siman', 'ccf # 4'),
(67, 6, 10, 101, NULL, '0.4059', '0.4059', '0', '2021-06-19 12:30:57', 'Mario Armando Perez', 'ccf # 4'),
(68, 6, 3, 91, NULL, '5.0000', '0.4059', '1', '2021-06-19 13:22:50', 'Sarita', 'ccf # 5'),
(69, 4, 50, 100, NULL, '0.4500', '0.4500', '0', '2021-06-19 13:25:00', 'Mario Armando Lopez', 'ccf # 5'),
(70, 10, 10, 100, NULL, '0.2500', '0.2500', '0', '2021-06-19 14:01:30', 'Mario Armando Lopez', 'fcf # 2'),
(71, 7, 50, 95, NULL, '0.2500', '0.4500', '1', '2021-06-19 14:04:08', 'Almacenes Ana', 'ccf # 6'),
(72, 7, 15, 145, NULL, '0.3810', '0.3810', '0', '2021-06-19 14:05:52', 'Wilmer', 'ccf # 6');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `Id` int(10) UNSIGNED NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `existencias` int(10) UNSIGNED DEFAULT 0,
  `precio` decimal(10,4) DEFAULT NULL,
  `costo` decimal(10,4) DEFAULT NULL,
  `descripcion` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `img` varchar(255) COLLATE utf8_spanish_ci NOT NULL DEFAULT '',
  `codigo` varchar(15) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`Id`, `nombre`, `existencias`, `precio`, `costo`, `descripcion`, `img`, `codigo`) VALUES
(4, 'Cuaderno Rayado #1', 50, '1.2500', '0.4500', 'Cuaderno Rayado #1', '', 'CUAD-GOB-3'),
(6, 'Libro #9 Liso', 94, '1.2500', '0.5525', 'Libro de paginas Lisas', '', 'LIBR-RO2'),
(7, 'Lapices', 130, '0.5000', '0.3810', 'lapices para escribir ', '', 'LAPIZ-H2'),
(8, 'Libro#3-Sociales', 40, '2.5000', '0.5600', 'Libro#3-Sociales', '', 'LIBRO-3SOC'),
(9, 'Lapices colores', 69, '1.2500', '0.2500', 'kit de colores', '', 'LAPIZ-COLOR'),
(10, 'Borradores#2', 90, '1.0500', '0.2500', 'Borradores#2', '', 'BORRA-DOR'),
(11, 'PinturasAcuarelas', 100, '1.5000', '0.6000', 'PinturasAcuarelas2', '', 'ACUA-RELA#3'),
(12, 'zacapuntas', 0, '1.0000', '0.0000', 'zacapuntas4', '', 'ZACA-PUNTAS2'),
(13, 'Crayolas', 0, '2.0000', '0.0000', 'Crayolas#3', '', 'CRAYO-LAS2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `Id` int(10) UNSIGNED NOT NULL,
  `tipo` enum('local','extranjero') COLLATE utf8_spanish_ci DEFAULT NULL,
  `clasificacion` enum('ninguno','pequenio','mediano','grande','otro') COLLATE utf8_spanish_ci DEFAULT NULL,
  `nit` varchar(17) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nrc` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `razon_social` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `direccion` varchar(255) COLLATE utf8_spanish_ci DEFAULT NULL,
  `telefono` varchar(12) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`Id`, `tipo`, `clasificacion`, `nit`, `nrc`, `nombre`, `razon_social`, `direccion`, `telefono`) VALUES
(1, 'local', 'ninguno', '', '', 'Proveedor de Prueba', '', '', ''),
(3, 'local', 'ninguno', '', '', 'Segundo Proveedor', '', '', ''),
(4, 'local', 'grande', '0614-290209-000-0', '100001-1', 'Siman', '', 'San Salvador', ''),
(5, 'local', 'mediano', '6831-290416-118-7', '321685-9', 'Tienda Flores', '', 'SantaTecla', '2252-8975'),
(6, 'local', 'pequenio', '0622-290298-556-7', '123566-9', 'Almacenes Ana', '', 'Santa Ana', ''),
(7, 'local', 'mediano', '4444-444444-444-4', '555555-5', 'Sarita', '', 'San Salvador', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(10) UNSIGNED NOT NULL,
  `nombre` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `usuario` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL,
  `contra` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL,
  `intentos` int(10) UNSIGNED DEFAULT 5,
  `estado` enum('activo','desactivado','bloqueado') COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`Id`, `nombre`, `usuario`, `contra`, `intentos`, `estado`) VALUES
(5, 'Administrador', 'admin', '12345678', 5, 'activo'),
(6, 'Diego Alas', 'alas06', '12345678', 4, 'activo');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_purchase_supplier` (`proveedor`);

--
-- Indices de la tabla `c_cuentas`
--
ALTER TABLE `c_cuentas`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `c_detallepartida`
--
ALTER TABLE `c_detallepartida`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_partida_detalle` (`partidaId`),
  ADD KEY `fk_detalle_cuenta` (`cuentaId`);

--
-- Indices de la tabla `c_partida`
--
ALTER TABLE `c_partida`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `c_saldo`
--
ALTER TABLE `c_saldo`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_saldo_cuenta` (`cuentaId`);

--
-- Indices de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_purchase_detail_product` (`producto`),
  ADD KEY `fk_purchase_detail` (`compra`);

--
-- Indices de la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_document_detail` (`documento`),
  ADD KEY `fk_detail_product` (`producto`);

--
-- Indices de la tabla `documento`
--
ALTER TABLE `documento`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_document_serie` (`serie`),
  ADD KEY `fk_document_client` (`cliente`);

--
-- Indices de la tabla `documento_serie`
--
ALTER TABLE `documento_serie`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `isr`
--
ALTER TABLE `isr`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `movimiento`
--
ALTER TABLE `movimiento`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_move_product` (`producto`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de la tabla `c_cuentas`
--
ALTER TABLE `c_cuentas`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT de la tabla `c_detallepartida`
--
ALTER TABLE `c_detallepartida`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=137;

--
-- AUTO_INCREMENT de la tabla `c_partida`
--
ALTER TABLE `c_partida`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT de la tabla `c_saldo`
--
ALTER TABLE `c_saldo`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT de la tabla `documento`
--
ALTER TABLE `documento`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT de la tabla `documento_serie`
--
ALTER TABLE `documento_serie`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `isr`
--
ALTER TABLE `isr`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `movimiento`
--
ALTER TABLE `movimiento`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `compra`
--
ALTER TABLE `compra`
  ADD CONSTRAINT `fk_purchase_supplier` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `c_detallepartida`
--
ALTER TABLE `c_detallepartida`
  ADD CONSTRAINT `fk_detalle_cuenta` FOREIGN KEY (`cuentaId`) REFERENCES `c_cuentas` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_partida_detalle` FOREIGN KEY (`partidaId`) REFERENCES `c_partida` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `c_saldo`
--
ALTER TABLE `c_saldo`
  ADD CONSTRAINT `fk_saldo_cuenta` FOREIGN KEY (`cuentaId`) REFERENCES `c_cuentas` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD CONSTRAINT `fk_purchase_detail` FOREIGN KEY (`compra`) REFERENCES `compra` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_purchase_detail_product` FOREIGN KEY (`producto`) REFERENCES `producto` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_documento`
--
ALTER TABLE `detalle_documento`
  ADD CONSTRAINT `fk_detail_product` FOREIGN KEY (`producto`) REFERENCES `producto` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_document_detail` FOREIGN KEY (`documento`) REFERENCES `documento` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `documento`
--
ALTER TABLE `documento`
  ADD CONSTRAINT `fk_document_client` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_document_serie` FOREIGN KEY (`serie`) REFERENCES `documento_serie` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `movimiento`
--
ALTER TABLE `movimiento`
  ADD CONSTRAINT `fk_move_product` FOREIGN KEY (`producto`) REFERENCES `producto` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
