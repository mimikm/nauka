<?php

class BazaDanych
{
    public $conn;
    public function __construct($servername, $username, $password, $baza)
    {

        // Create connection
        $this->conn = new mysqli($servername, $username, $password, $baza);

        // Check connection
        if ($this->conn->connect_error) {
            die('Connection failed: '.$this->conn->connect_error);
        }
        echo 'Connected successfully';
    }
}

interface Matematyka
{
    public function dzielenie($a, $b);
    public function odejmowanie($a, $b);
    public function dodawanie($a, $b);
    public function mnozenie($a, $b);
}

interface MatematykaZaawansowana
{
    public function procent($liczba, $procent);
    public function potega($liczba, $potega);
}

abstract class ZaawansowanyKalkulator extends BazaDanych implements MatematykaZaawansowana
{
    public function procent($liczba, $procent)
    {
        return $liczba * $procent / 100;
    }

    public function potega($liczba, $potega)
    {
        $pl = $liczba;
        for ($i = 1; $i < $potega; ++$i) {
            $liczba = $pl * $liczba;
        }

        return $liczba;
    }
}

class Kalkulator extends ZaawansowanyKalkulator implements Matematyka
{
    public function mnozenie($a, $b)
    {
        return $a * $b;
    }
    public function dzielenie($a, $b)
    {
        if ($b == 0) {
            return 'nie dziel przez zero';
        }

        return $a / $b;
    }
    public function odejmowanie($a, $b)
    {
        return $a - $b;
    }
    public function dodawanie($a, $b)
    {
        return $a + $b;
    }
}

// $mn = new Kalkulator('192.168.1.12', 'root', 'kornelius');
// echo $mn->mnozenie(4, 5)."\n";
// echo $mn->dzielenie(4, 0)."\n";
// echo $mn->odejmowanie(4, 5)."\n";
// echo $mn->dodawanie(4, 5)."\n";
// echo $mn->procent(200, 25)."\n";
// echo $mn->potega(3, 4)."\n";
// public
// protected
// private
;
