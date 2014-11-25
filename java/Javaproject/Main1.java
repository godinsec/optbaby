package Test;

import redis.clients.jedis.Jedis;

public class Main1 {

	/**
	 * @param args
	 */
	public static Jedis jedis = new Jedis("127.0.0.1");
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		jedis.flushDB();

		jedis.rpush("home", "xx1");
		jedis.rpush("home", "xx2");
		jedis.rpush("home", "xx3");
		jedis.rpush("home", "xx4");
		jedis.rpush("home", "xx5");
		jedis.rpush("home", "xx6");
		jedis.rpush("home", "xx7");
		jedis.rpush("home", "xx8");
		jedis.rpush("home", "xx9");
		jedis.rpush("home", "xx10");
		jedis.rpush("home", "xx11");


		
	}

}
