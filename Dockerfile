FROM ubuntu:16.04
RUN apt-get update -y && apt-get install
RUN apt-get install -y php5 php5-fpm php5-cli php5-curl php5-mysql

RUN mkdir /var/www/html -p
RUN chown -R www-data:www-data /var/www/html

RUN sed -i 's/^short_open_tag = [Oo]ff/short_open_tag = On/' /etc/php5/fpm/php.ini

VOLUME ["/var/www/html/dominik"]

EXPOSE 80

CMD service php5-fpm start
