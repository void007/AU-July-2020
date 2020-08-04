//

import java.util.Random;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;

class ProducerBQ implements Runnable
{
	private final BlockingQueue  sharedQ;
	
	public ProducerBQ(BlockingQueue  sharedQ)
	{
		this.sharedQ = sharedQ;
	}
	
	@Override
	public void run(){
		
		while(true)
		{
			try
			{
				for(int i=0;i<10;i++){
				Random random = new Random(); 
				int number = random.nextInt(100);
				System.out.println("Producing value " + number);
				if(sharedQ.size()==10){
					System.out.println("Queue is already full");
					Thread.sleep(1000);
				}
				else{
				sharedQ.put(number);
				}
				}
			}
			catch(InterruptedException ie)
			{
				System.err.println("Error :: " + ie);
			}
		}
	}
}

//
class ConsumerBQ implements Runnable
{
	private final BlockingQueue  sharedQ;
	
	public ConsumerBQ(BlockingQueue  sharedQ)
	{
		this.sharedQ = sharedQ;
	}
	
	@Override
	public void run(){
		
		while(true)
		{
			try
			{
				if(sharedQ.remainingCapacity()==0){
					System.out.println("Queue is Empty");
					Thread.sleep(1000);
				}
				else{
				System.out.println("Consumed value " + sharedQ.take());
				}
				//Thread.sleep(100);
				
			}
			catch(InterruptedException ie)
			{
				System.err.println("Error :: " + ie);
			}
		}
	}
}

//
public class BlockingQueueImple {

	public static void main(String[] args) throws InterruptedException {
		int capacity=10;
		BlockingQueue sharedQ = new LinkedBlockingQueue(capacity);
		System.out.println("Size of queue:"+sharedQ.size());
		
		Thread consumerThread = new Thread(new ConsumerBQ(sharedQ));
		Thread producerThread = new Thread(new ProducerBQ(sharedQ));
		
		producerThread.start();
		consumerThread.start();
		
		producerThread.join();
		
	}

}